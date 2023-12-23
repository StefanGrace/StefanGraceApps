<?php # read.php
	// This page shows the messages in a thread.
	
	// Set page title:
	$page_title = 'Post';
	
	// Include the header:
	include('header.html');
	
	// Conent to the database:
	require('mysqli_connect.php');
	
	// Check for a thread ID...
	$tid = FALSE;
	if (isset($_GET['tid']) && filter_var($_GET['tid'], FILTER_VALIDATE_INT, array('min_range' => 1)) ) {
		// Create a shorthand version of the thread ID:
		$tid = $_GET['tid'];
		// Convert the date if the user is logged in:
		if (isset($_SESSION['user_tz'])) {
			$posted = "CONVERT_TZ(p.posted_on, 'UTC', '{$_SESSION['user_tz']}')";
		} else {
			$posted = 'p.posted_on';
		}
		// Run the query:
		$q = "SELECT t.subject, p.message, username, DATE_FORMAT($posted, '%e-%b-%y %l:%i %p') AS posted FROM threads AS t LEFT JOIN posts AS p USING (thread_id) INNER JOIN users AS u ON p.user_id = u.user_id WHERE t.thread_id = $tid ORDER BY p.posted_on ASC";
		$r = mysqli_query($dbc, $q);
		if (!(mysqli_num_rows($r) > 0)) {
			$tid = FALSE; // Invalid thread ID!
		}
	}
	echo '<div class="content">';
	
	if ($tid) { // Get the messages in this thread...
		$printed = FALSE; // Flag variable.
		// Fetch each:
		while ($messages = mysqli_fetch_array($r, MYSQLI_ASSOC)) {
			// Only need to print the subject once!
			if (!$printed) {
				echo "<h2>{$messages['subject']}</h2>\n";
				$printed = TRUE;
			}
			// Print the message:
			echo "<p><b>{$messages['username']}</b> {$messages['posted']}<br /><br />{$messages['message']}</p><br />\n";
		}
	} else { // Invalid thread ID!
		echo '<p>This page has been accessed in error.</p>';
	}
	echo '</div>';
	
	include ('footer.html');
?>