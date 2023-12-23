<?php # browse_products.php
	// This page displays the available products (products)
	
	// Set the page title and display the HTML header
	$page_title = 'Browse Products';
	include('header.html');
	
	require('mysqli_connect.php');
	
	// Sort
	$sort_by = "categories.category_id, products.product_id";
	if(isset($_GET['sort'])) {
		switch ($_GET['sort']) {
			case 'price': 
				$sort_by = "products.price";
				break;
		}
	}
	
	// Default query for this page
	$q = "SELECT categories.category_id, category_name, product_name, price, description, product_id FROM categories, products 
		WHERE categories.category_id = products.category_id ORDER BY $sort_by";
	
	// Are we looking at a particular category?
	if (isset($_GET['cid']) && filter_var($_GET['cid'], FILTER_VALIDATE_INT, array('min_range' => 1))) {
		// Overwrite query
		$q = "SELECT categories.category_id, category_name, product_name, price, description, product_id FROM categories, products 
			WHERE categories.category_id = products.category_id AND products.category_id={$_GET['cid']} ORDER BY products.product_id";
	}
	
	// Create the table head 
	?>
	<table border="0" width="100%" cellspacing="0" align="center" class="product-table">
		<tr class="header" id="search">
			<td align="right" colspan="4">
				<form name="searchForm">
					Search: <input id="search-box" name="searchBox" size="20"></input>
					<input type="button" id="go-button" type="submit" onclick="searchProducts()" value="Go" />
				</form>
			</td>
		</tr>
		<tr class="table-headings">
			<td align="left" width="20%" class="left-column"><a href="browse_products.php">Category</a></td>
			<td align="left" width="25%">Product</td>
			<td align="left" width="40%">Description</td>
			<td align="right" width="15%" class="right-column"><a href="browse_products.php?sort=price">Price</a></td>
		</tr>
	<?php
	
	// Display all the products, linked to URLs
	$r = mysqli_query($dbc, $q);
	$even = FALSE;
	while ($row = mysqli_fetch_array ($r, MYSQLI_ASSOC)) {
		
		// Highlight even rows
		$even = !$even;
		if ($even) {
			$tr_class = ' class="even-row product-listing"';
		} else {
			$tr_class = ' class="product-listing"';
		}
		
		// Display each record
		echo "\t<tr{$tr_class}>
			<td align=\"left\" class=\"left-column\"><a href=\"browse_products.php?cid={$row['category_id']}\">{$row['category_name']}</a></td>
			<td align=\"left\"><a href=\"view_product.php?pid={$row['product_id']}\">{$row['product_name']}</a></td>
			<td align=\"left\">{$row['description']}</td>
			<td align=\"right\" class=\"right-column\">\${$row['price']}</td>
		</tr>\n";	
		
	}
	
	echo '</table>';
	mysqli_close($dbc);
	include('footer.html');
	
?> 
<script type="text/javascript" src="search.js" charset="utf-8"></script>