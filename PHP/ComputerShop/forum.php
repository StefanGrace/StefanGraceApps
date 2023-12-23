<?php # forum.php
	// This page shows the threads in a forum
	
	// Set page title:
	$page_title = 'Forum';
	
	// Include the header:
	include('header.html');
	
	// Conent to the database:
	require('mysqli_connect.php');
	
	// Retrieve all the messages in this forum...
	
	// If the user is logged in and has chosen a time zone, use that to convert the dates and times:
	if (isset($_SESSION['user_tz'])) {
		$first = "CONVERT_TZ(p.posted_on, 'UTC', '{$_SESSION['user_tz']}')";
		$last = "CONVERT_TZ(p.posted_on, 'UTC', '{$_SESSION['user_tz']}')";
	} else {
		$first = 'p.posted_on';
		$last = 'p.posted_on';
	}
	
	/* The query for retrieving all the threads in this forum, along with the original user,
	when the thread was first posted, when it was last replied to, and how many replies it's had: */
	$q = "SELECT thread_id, subject, posted_by AS username, replies AS responses FROM threads";
	$r = mysqli_query($dbc, $q);
	if (mysqli_num_rows($r) > 0) {
		
		// Create a table:
		echo '<div class="content">';
		echo '<table width="100%" border="0" cellspacing="2" cellpadding="2" align="center" >
				<tr class="table-headings">
					<td align="left" width="50%">Subject:</td>
					<td align="left" width="20%">Posted by:</td>
					<td align="center" width="10%">Replies:</td>
				</tr>';

		// Fetch each thread:
		while ($row = mysqli_fetch_array($r, MYSQLI_ASSOC)) {
			echo '<tr>
				<td align="left"><a href="read.php?tid=' . $row['thread_id'] . '">' . $row['subject']. '</a></td>
					<td align="left">' . $row['username'] . '</td>
					<td align="center">' . $row['responses'] . '</td>
				</tr>';
		}
		echo '</table>'; // Complete the table.
		
	} else {
		echo '<p>There are currently no messages in this forum.</p>';
	}
	echo '</div>';
	
	// Include the HTML footer file:
	include('footer.html');
?>