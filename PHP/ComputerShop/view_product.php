<?php # view_print.php
	// This page displays the details for a particular product
	
	$row = FALSE;
	
	if (isset($_GET['pid']) && filter_var($_GET['pid'], FILTER_VALIDATE_INT, array('min_range' => 1))) {
		$pid = $_GET['pid'];
		
		// Get the product info
		require('mysqli_connect.php'); // Connect to the database
		$q = "SELECT category_name, product_name, price, description, image_name FROM categories, products WHERE categories.category_id = products.category_id AND products.product_id=$pid";
		$r = mysqli_query($dbc, $q);
		if (mysqli_num_rows($r) == 1) {
			
			// Fetch the information
			$row = mysqli_fetch_array ($r, MYSQLI_ASSOC);
			
			// Start the HTML page
			$page_title = $row['product_name'];
			include('header.html');
			
			// Display a header
			echo "<div align=\"center\"><b> {$row['product_name']}</b> {$row['category_name']}<br />";
			
			// Print the price
			echo "<br />\${$row['price']}<br /><a href=\"add_cart.php?pid=$pid\">Add to Cart</a></div><br /><div align=\"center\">";
			
			// Display the image
			if (file_exists("uploads/$row[image_name].jpg")) {
				echo "<a href=\"uploads/$row[image_name].jpg\"><image src=\"uploads/$row[image_name].jpg\" width=\"200\" alt=\"Product Image\" /></a>"; 
			} else if (file_exists('images/unavailable.png')) {
				echo "<image src=\"images/unavailable.png\" alt=\"Image Unavailable\" />";
			} else {
				echo "<p>No image available</p>";
			}
			
			// Display the description
			echo '<table><tr width="200px"><td><p align="left">' . ((is_null($row['description'])) ? '(No description available)' : $row['description']) . '</p></td></tr></table></div>';
		}
		mysqli_close($dbc);
	}
	
	if (!$row) { // Show an error message
		$page_title = 'Error';
		include('header.html');
		echo '<div align="center">This page has been accessed in error!</div>';
	}
	
	// Complete the page
	include('footer.html');
	
?>