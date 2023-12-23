<!DOCTYPE html>
<html>
	<head>
		<title>Add a product</title>
	</head>
	
	<body>
		<?php
			// This page allow the administrator to add a product
			
			require ('mysqli_connect.php');
			
			if ($_SERVER['REQUEST_METHOD'] == 'POST') { // Handle the form
				
				// Validate the incoming data
				$errors = array();
				
				// Check for a product name
				if (!empty($_POST['product_name'])) {
					$pn = strip_tags(trim($_POST['product_name']));
				} else {
					$errors[] = 'Please enter the product\'s name';
				}
				
				// Check for an image
				if (is_uploaded_file($_FILES['image']['name'])) {
					
					// Create a temoraray file name
					$temp = 'uploads/' . md5($_FILES['image']['name']);
					
					// Move the file over
					if (move_uploaded_file($_FILE['image']['tmp_name'], $temp)) {
						echo '<p>The file has been uploaded</p>';
						// Set the $i variable to the image's name
						$i = $_FILES['image']['tmp_name'];
					} else { // couldn't move the file over
						$errors[] = 'The file could not be moved.';
						$temp = $_FILES['image']['tmp_name'];
					}
					
				} else {
					$errors[] = 'No file was uploaded.';
					$temp = NULL;
				}
				
				
				// Check for a price
				if (is_numeric($_POST['size']) && ($_POST['price'] > 0)) {
					$p = (float) $_POST['price'];
				} else {
					$errors[] = 'Please enter the product\'s price!';
				}
				
				// Check for a description (not required)
				$d = (!empty($_POST['description'])) ? trim($_POST['description']) : NULL;
				
				// Validate the category
				if (isset($_POST['category']) && filter_var($_POST['category'], FILTER_VALIDATE_INT, array('min_range' => 1))){
					$a = $_POST['category'];
				} else { // No category selected
					$errors[] = 'Please select the product\'s category!';
				}
				
				if (empty($errors)) { // If everything's OK.
				
					// Add the product to the database
					$q = 'INSERT INTO products (category_id, product_name, price, description, image_name) VALUES (?, ?, ?, ?, ?)';
					$stmt = mysqli_prepare($dbc, $q);
					mysqli_stmt_bind_param($stmt, 'isdsss', $a, $pn, $p, $s, $d, $i);
					mysqli_stmt_execute($stmt);
					
					// Check the results
					if (mysqli_stmt_affected_rows($stmt) == 1) {
						// Print a message
						echo '<p>The product has been added.</p>';
						// Rename the image
						$id = mysqli_stmt_insert_id($stmt); // Get the product ID
						rename ($temp, "uploads/$id");
						// Clear $_POST
						$_POST = array();
						
					} else { // Error
						echo '<p style="font-weight: bold; color: #C00">Your submission could not be processed due to a system error.</p>';
					}
					
					mysqli_stmt_close($stmt);
					
				}
				
				// Delete the uploaded file if it still exists
				if (isset($temp) && file_exists($temp) && is_file($temp)) {
					unlink($temp);
				}
				
			}
			
			// Check for any errors and product them
			if (!empty($errors) && is_array($errors)) {
				echo '<h1>Error!</h1><p style="font-weight: bold; color: #C00">The following error(s) occurred:<br />';
				foreach ($errors as $msg) {
					echo " - $msg<br />\n";
				}
				echo 'Please reselect the product image and try again.</p>';
			}
			
		?>
		<!-- Display the form -->
		<h1>Add a Print</h1>
		
		<form enctype="multipart/form-data" action="add_product.php" method="post">	
			<input type="hidden" name="MAX_FILE_SIZE" value="524288" />
			<fieldset>
				<legend>Fill out the form to add a product to the catalog:</legend>
				<p><b>Print Name:</b><input type="text" name="product_name" size="30" maxlength="60" value="<?php if (isset($_POST['product_name'])) echo htmlspecialchars($_POST['product_name']);?>" /></p>
				
				<p><b>Image:</b><input type="file" name="image" /></p>
				
				<p><b>Artist:</b><select name="category"><option>Select One</option>
				<?php // Retrieve all the categories and add to the pull-down menu.
					$q = "SELECT category_id, category_name FROM categories ORDER BY last_name, first_name ASC";
					$r = mysqli_query ($dbc, $q);
					if (mysqli_num_rows($r) > 0) {
						while ($row = mysqli_fetch_array ($r, MYSQLI_NUM)) {
							echo "<option value=\"$row[0]\"";
							//Check for stickyness
							if (isset($_POST['existing']) && ($_POST['existing'] == $row[0])) echo 'selected="selected"';
							echo ">$row[1]</option>\n";
						}
					} else {
						echo '<option>Please add a new category first.</option>';
					}
					mysqli_close($dbc); // Close the database connection.
				?>
				</select></p>
				<p><b>Price:</b> <input type="text" name="price" size="10" maxlength="10" value="<?php if (isset($POST['price'])) echo $_POST['price']; ?>" /><small>Do not include the dollar sign or commas.</small></p>
				<p><b>Description:</b> <textarea name="description" cols="40" rows="5"><?php if (isset($_POST['description'])) echo $_POST['description']; ?></textarea> (optional)</p>
			</fieldset>
			<div align="center"><input type="submit" name="submit" value="Submit" /></div>
		</form>

		
	</body>
</html>