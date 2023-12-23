<?php # view_cart.php
	// This page displays the contents of the shopping cart.
	
	// Set the page title and include the HTML header:
	$page_title = 'View Your Shopping Cart';
	include('header.html');
	
	// Retrieve all of the information for the products in the cart:
	require('mysqli_connect.php'); // Connect to the database.
	$q = "SELECT item_id, item_category, product_name, item_price, qty FROM cart";
	$r = mysqli_query($dbc, $q);
	
	// Create a form and a table:
	?>
	<table border="0" width="90%" cellspacing="3" cellpadding="3" align="center">
	<tr class="table-headings">
		<td align="left" width="30%">Product Name</td>
		<td align="left" width="30%">Category</td>
		<td align="right" width="10%">Price</td>
		<td align="center" width="10%">Qty</td>
		<td align="right" width="10%">Total Price</td>
	</tr>
	
	<?php
	// Print each item...
	$total_price = 0; // Total cost of the order.
	$total_items = 0; // Total number of items in the order.
	while ($row = mysqli_fetch_array ($r, MYSQLI_ASSOC)) {
		// Calculate the total and sub-totals.
		$subtotal = $row['item_price'] * $row['qty'];
		$total_price += $subtotal;
		$total_items += $row['qty'];
		// Print the row:
		echo "<tr>
			<td align=\"left\">{$row['product_name']}</td>
			<td align=\"left\">{$row['item_category']}</td>
			<td align=\"right\">\${$row['item_price']}</td>
			<td align=\"center\">{$row['qty']}</td>
			<td align=\"right\">$" . number_format ($subtotal, 2) . "</td>
		</tr>\n";
	}
	echo "<tr class=\"totals\">
		<td>Total</td>
		<td></td>
		<td></td>
		<td align=\"center\">$total_items</td>
		<td align=\"right\">$" . number_format ($total_price, 2) . "</td>
	</tr>"
	?></table><?php
	// Include the HTML footer
	include('footer.html');
?>