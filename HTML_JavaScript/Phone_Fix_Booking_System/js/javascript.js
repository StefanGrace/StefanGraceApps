var bond;
var serviceFee;
var total;
var gst;
var totalPlusGST;
var customerType;

//When the document is ready
$(document).ready(function() {
	
	var bookmark = 0;
	var cost = [];
	var itemTypes = [];
	var warranty;
	
	
	//Add a date picker to the "Purchase Date" field
	$("#purchase-date").datepicker({
		changeMonth: true,
		changeYear: true,
		dateFormat: "yy-mm-dd",
		numberOfMonths: 1
	});
	
	//Add a date picker to the "Repair Date" field
	$("#repair-date").datepicker({
		changeMonth: true,
		changeYear: true,
		dateFormat: "yy-mm-dd",
		numberOfMonths: 1
	});
	
	//When the user clicks submit button, check the entered values
	$('form').submit(function(e){
		//Prevent the default action: send to server
		e.preventDefault();
		
		//Make all the error messages disappear
		$('p.error-message').hide();
		
		//Get entered values
		if ($('#consumer').prop('checked')) {
			customerType = 'consumer';
		} else if ($('#business').prop('checked')) {
			customerType = 'business';
		}
		var title = $('#title').val();
		var firstName = $('#first-name').val();
		var lastName = $('#last-name').val();
		var street = $('#street').val();
		var suburb = $('#suburb').val();
		var city = $('#city').val();
		var postCode = $('#post-code').val();
		var phoneNumber = $('#phone-number').val();
		var email = $('#email').val();
		var purchaseDate = $('#purchase-date').val();
		var repairDate = $('#repair-date').val();
		warranty = $('#warranty').prop('checked');
		var IMEINumber = $('#imei-number').val();
		var make = $('#make').val();
		var modelNumber = $('#model-number').val();
		var faultCategory = $('#fault-category').val();
		var description = $('#description').val();
		var itemType = $('#item-type').val();
		
		//These symbols are allowed in thoes input fields
		var nameSymbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz -";
		var numbers = "0123456789";
		var phoneNumberSymbols = "0123456789()-+ ";
		
		//Check costomer type?
		if (customerType != "business" && customerType != "consumer") {
			$('#cust-type').after('<p class="error-message">Please select your customer type</p>');
			return false;
		}
		
		//Check first name?
		for (var i = 0; i < firstName.length; i++) {
			var allowed = 0;
			for (var j = 0; j < nameSymbols.length; j++) {
				if (firstName[i] == nameSymbols[j]) {
					allowed++;
				}
			}
			if (allowed == 0) {
				$('#first-name').after('<p class="error-message">A name can only contain letters, hyphens and spaces</p>');
				return false;
			}
		}
		if (firstName == "" || firstName == null) {
			$('#first-name').after('<p class="error-message">Please enter first your name</p>');
			return false;
		}
		
		//Check last name?
		for (var i = 0; i < lastName.length; i++) {
			var allowed = 0;
			for (var j = 0; j < nameSymbols.length; j++) {
				if (lastName[i] == nameSymbols[j]) {
					allowed++;
				}
			}
			if (allowed == 0) {
				$('#last-name').after('<p class="error-message">A name can only contain letters, hyphens and spaces</p>');
				return false;
			}
		}
		if (lastName == "" || lastName == null) {
			$('#last-name').after('<p class="error-message">Please enter your last name</p>');
			return false;
		}
		
		//Check street?
		if (street == "" || street == null) {
			$('#street').after('<p class="error-message">Please enter your street</p>');
			return false;
		}
		
		// No need to check suburb
		
		//Check street?
		if (city == "" || city == null) {
			$('#city').after('<p class="error-message">Please enter your city</p>');
			return false;
		}
		
		//Check post code?
		for (var i = 0; i < postCode.length; i++) {
			var allowed = 0;
			for (var j = 0; j < numbers.length; j++) {
				if (postCode[i] == numbers[j]) {
					allowed++;
				}
			}
			if (allowed == 0) {
				$('#post-code').after('<p class="error-message">A post code can only contain numbers</p>');
				return false;
			}
		}
		if (postCode.length != 4) {
			$('#post-code').after('<p class="error-message">Your post code must be 4 digits</p>');
			return false;
		}
		
		//Check phone number?
		for (var i = 0; i < phoneNumber.length; i++) {
			var allowed = 0;
			for (var j = 0; j < phoneNumberSymbols.length; j++) {
				if (phoneNumber[i] == phoneNumberSymbols[j]) {
					allowed++;
				}
			}
			if (allowed == 0) {
				$('#phone-number').after('<p class="error-message">A phone number can only contain numbs, hyphens, pluses, brackets and spaces</p>');
				return false;
			}
		}
		if (phoneNumber == "" || phoneNumber == null) {
			$('#phone-number').after('<p class="error-message">Please enter phone number</p>');
			return false;
		}
		
		//Check email?
		if (email == "" || email == null) {
			$('#email').after('<p class="error-message">Please enter your email</p>');
			return false;
		}
		
		//Check purchase date?
		if (purchaseDate == "" || purchaseDate == null) {
			$('#purchase-date').after('<p class="error-message">Please enter purchase date</p>');
			return false;
		}
		var purchaseDateDate = new Date(purchaseDate);
		if (!(purchaseDateDate.getDate() < 32)) {
			$('#purchase-date').after(`<p class="error-message">${purchaseDate} is not a valid date. Dates must be formatted as YYYY-MM-DD.</p>`);
			return false;
		}
		var today = new Date();
		if (purchaseDateDate.getTime() > today.getTime()) {
			$('#purchase-date').after('<p class="error-message">The purchase date cannot be in the future</p>');
		}
		
		//Check repair date?
		if (repairDate == "" || repairDate == null) {
			$('#repair-date').after('<p class="error-message">Please enter repair date</p>');
			return false;
		}
		repairDateDate = new Date(repairDate);
		if (!(purchaseDateDate.getDate() < 32)) {
			$('#repair-date').after(`<p class="error-message">${purchaseDate} is not a valid date. Dates must be formatted as YYYY-MM-DD.</p>`);
			return false;
		}
		
		//Check imei number?
		for (var i = 0; i < IMEINumber.length; i++) {
			var allowed = 0;
			for (var j = 0; j < numbers.length; j++) {
				if (IMEINumber[i] == numbers[j]) {
					allowed++;
				}
			}
			if (allowed == 0) {
				$('#imei-number').after('<p class="error-message">IMEI can only contain numbers</p>');
				return false;
			}
		}
		if (IMEINumber.length != 15) {
			$('#imei-number').after('<p class="error-message">Your IMEI number must be 15 digits</p>');
			return false;
		}
		
		//Check description?
		if (description == "" || description == null) {
			$('#description').after('<p class="error-message">Please add a description</p>');
			return false;
		}
		
		//Calculate cost
		calculatecost(warranty, cost)
		
		//Display invoice 
		var now = new Date();
		var jobNumber = Math.floor((Math.random() * 10000));
		var invoiceWindow = window.open('','_blank');
		switch (title) {
			case "mr":
				title = "Mr";
				break;
			case "mrs":
				title = "Mrs";
				break;
			case "ms":
				title = "Ms";
				break;
			case "miss":
				title = "Miss";
				break;
			case "dr":
				title = "Dr";
				break;
		}
		if (suburb.length > 0) {
			suburb += ", ";
		}
		var underWarranty;
		if (warranty) {
			underWarranty = "Yes &#10004";
		} else {
			underWarranty = "No &#10008";
		}
		var tableString = '<table id="courtesy-phone-table"><tr><th>Item</th><th>Cost</th></tr>';
		for (var i = 0; i < bookmark; i++) {
			tableString += `<tr><td>${itemTypes[i]}</td><td>$${cost[i]}</td></tr>`;
		}
		tableString += '</table>';
		invoiceWindow.document.write(`
			<html>
				<head>
					<title>Repair Booking Sheet</title>
					<link rel="stylesheet" href="css/repair-booking-sheet.css" type="text/css">
				</head>
				<body>
					<div class="invoice-layout">
						<div>
							<h1>Repair Booking</h1>
						</div>
						<div>
							<h2>Amount Due: $${totalPlusGST.toFixed(2)}</h2>
						</div>
						<div>
							<h3>Customer</h3>
							<p>
								${title} ${firstName} ${lastName}</br>
								${street}</br>
								${suburb}${city} ${postCode}</br>
								${phoneNumber}</br>
								${email}</br>
							</p>
							<br>
						</div>
						<div>
							<h3>Repair Job</h3>
							<table>
								<tr><td class="key">Job Number:</td><td>${jobNumber}</td></tr>
								<tr><td class="key">Invoice Date:</td><td>${formatLongDate(new Date(repairDate)) + " - " + format24hourTime(now)}</td></tr>
								<tr><td class="key">Payment Date:</td><td>${formatLongDate(now)}</td></tr>
							</table>
							<br>
						</div>
					</div>
					<h3>Repair Details</h3>
					<table>
						<tr><td class="key">Purchase Date:</td><td>${formatShortDate(new Date(purchaseDate))}</td></tr>
						<tr><td class="key">Repair Date/Time:</td><td>${formatShortDate(new Date(repairDate)) + " - " + format12hourTime(now)}</td></tr>
						<tr><td class="key">Under Warranty:</td><td>${underWarranty}</td></tr>
						<tr><td class="key">IMEI Number:</td><td>${IMEINumber}</td></tr>
						<tr><td class="key">Device Make:</td><td>${make}</td></tr>
						<tr><td class="key">Model Number:</td><td>${modelNumber}</td></tr>
						<tr><td class="key">Fault Category:</td><td>${faultCategory}</td></tr>
						<tr><td class="key">Description:</td><td>${description}</td></tr>
					</table>
					<br>
					<h3>Courtesy Loan Device Details</h3>
					${tableString}
					<br>
					<h3>Totals</h3>
					<table>
						<tr><td class="key">Bond:</td><td>${"$" + bond.toFixed(2)}</td></tr>
						<tr><td class="key">Service Fee:</td><td>${"$" + serviceFee.toFixed(2)}</td></tr>
						<tr><td class="key">Total:</td><td>${"$" + total.toFixed(2)}</td></tr>
						<tr><td class="key">GST:</td><td>${"$" + gst.toFixed(2)}</td></tr>
						<tr><td class="key">Total(+GST):</td><td>${"$" + totalPlusGST.toFixed(2)}</td></tr>
					</table>
				</body>
			</html>
		`);

	});
	
	//Disable warranty checkbox if purchase date was more that 2 years ago
	$('#purchase-date').change(function(){
		var purchaseDate = $('#purchase-date').val();
		var purchaseDateDate = new Date(purchaseDate);
		var today = new Date();
		if (today.getTime() - purchaseDateDate.getTime() > 1000*60*60*24*365*2 /*millisecons in 2 years*/) {
			$('#warranty').prop('disabled', true);
			warranty = false;
		} else {
			$('#warranty').prop('disabled', false);
			warranty = $('#warranty').prop('checked');
		}
		calculatecost(warranty, cost);
	});
	
	//When the user clicks the "add" button, the the item to the table
	$('#add-button').click(function(e) {
		var itemType = $('#item-type').val();
		switch (itemType){
			case 'iphone':
				cost[bookmark] = 275;
				itemTypes[bookmark] = "iPhone";
				break;
			case 'other-phone':
				cost[bookmark] = 100;
				itemTypes[bookmark] = "Other Phone";
				break;
			case 'charger':
				cost[bookmark] = 30;
				itemTypes[bookmark] = "Charger";
				break;
		}
		generateTable(cost, itemTypes, bookmark);
		bookmark++;
		$('.remove-button').click(function(e) {
			var itemToRemove = parseInt(this.name);
			cost.splice(itemToRemove, 1);
			itemTypes.splice(itemToRemove, 1);
			bookmark--;
			calculatecost(warranty, cost);
			generateTable(cost, itemTypes, bookmark - 1);
			$('.remove-button').click(function(e) {
				var itemToRemove = parseInt(this.name);
				cost.splice(itemToRemove, 1);
				itemTypes.splice(itemToRemove, 1);
				bookmark--;
				calculatecost(warranty, cost);
				generateTable(cost, itemTypes, bookmark - 1);
					$('.remove-button').click(function(e) {
					var itemToRemove = parseInt(this.name);
					cost.splice(itemToRemove, 1);
					itemTypes.splice(itemToRemove, 1);
					bookmark--;
					calculatecost(warranty, cost);
					generateTable(cost, itemTypes, bookmark - 1);
				});
			});
		});
		calculatecost(warranty, cost);
	});
	
	//When the user clicks the "FAQ" button, display the FAQ page
	$('#faq-button').click(function(e) {
		var FAQs = [
			{
			"question": "Why do I have to pay a service fee?",
			"answer" : "A service fee is only charged for repairs to devices that are no longer under warran-ty. Business customers are not charged a service fee in accord with the terms of their contract."
			},
			{
			"question": "What is the bond for?",
			"answer" : "The bond is to cover any damage done to the courtesy phone and/or charger. The bond will be refunded upon the safe and un-damaged return of the phone and charger."
			},
			{
			"question": "Do I need a charger with my courtesy phone?",
			"answer" : "No, a charger is optional. You can add one with the 'Add charger' button. If you don't want one but added one by accident, you can remove it by clicking on the 'Remove charger' button."
			},
			{
			"question": " Why isn't my phone under warranty?",
			"answer" : " The length of your phone's warranty depends on the warranty package you chose upon purchase. The standard is 24 months and is calculated from its purchase date."
			},
			{
			"question": " How long will my repair take?",
			"answer" : " Depends on your phone broken status. It takes normally 5 to 7 working days."
			},
			{
			"question": " How do you protect the private information in my phone?",
			"answer" : " We comply with all relevant laws regarding privacy and client confidentiality."
			},
			{
			"question": " Where do you get your replacement parts?",
			"answer" : " We will send you a quote of all possible vendors who supply replacement parts for your references and your choice."
			},
			{
			"question": " What happens if my phone is further damage after leaving it with you?",
			"answer" : " We make sure that it never happens."
			},
			{
			"question": " What kind of warranty do you offer and what does it cover?",
			"answer" : "1 month is the average warranty period. These warranties covers parts and service only."
			},
			{
			"question": " What does the repair estimate include?",
			"answer" : " The repair price estimate includes both replacement parts and labor."
			}
		];
		var FAQWindow = window.open('','_blank');
		var articleHTML = "";
		for (var i = 0; i < FAQs.length; i++) {
			articleHTML += `<div class="article"><h2>${FAQs[i]["question"]}</h2><p>${FAQs[i]["answer"]}</p></div>`
		}
		FAQWindow.document.write(`
			<html>
				<head>
					<meta name="viewport" content="width=device-width" charset="UTF-8">
					<title>FAQ</title>
					<link rel="stylesheet" href="css/style.css" type="text/css">
				</head>
				<body>
					<header>
						<h1 class="title-area">Phone Fix Booking FAQs</h1>
					</header>
					<main class="article-background">
						${articleHTML}
					</main>
				</body>
				<footer>
					<p>Stefan Grace, Copyright &copy; 2019</p>
				</footer>
			</html>
		`);
	});
	
	//When the user clicks the "warranty" button, calculate the cost
	$('#warranty').click(function(e) {
		warranty = $('#warranty').prop('checked');
		calculatecost(warranty, cost);
	});
	
	//When the user clicks the "consumer" button, calculate the cost
	$('#consumer').click(function(e) {
		customerType = 'consumer';
		calculatecost(warranty, cost);
	});
	
	//When the user clicks the "business" button, calculate the cost
	$('#business').click(function(e) {
		customerType = 'business';
		calculatecost(warranty, cost);
	});
	
	
});


//Generate Courtesy phone table
function generateTable(cost, itemTypes, bookmark) {
	var tableString = '<table id="courtesy-phone-table"><tr><th>Item</th><th>Cost</th><th></th></tr>';
	for (var i = 0; i < bookmark + 1; i++) {
		tableString += `<tr><td>${itemTypes[i]}</td><td>$${cost[i]}</td><td><button type="button" name="${i}" class="btn btn-primary remove-button">Remove</button></td></tr>`;
	}
	tableString += '</table>';
	$('#courtesy-phone-table').remove();
	$('#add-button').after(tableString);
}

//Calculate cost
function calculatecost(warranty, cost) {
	bond = 0;
	for (var i = 0; i < cost.length; i++) {
		bond += cost[i];
	}
	if (customerType != 'consumer') {
		bond = 0;
	}
	if (warranty) {
		serviceFee = 0;
	} else {
		serviceFee = 85;
	}
	total = bond + serviceFee;
	gst = total * 0.15;
	totalPlusGST = total + gst;
	$('#bond').val("$" + bond.toFixed(2));
	$('#service-fee').val("$" + serviceFee.toFixed(2));
	$('#total').val("$" + total.toFixed(2));
	$('#gst').val("$" + gst.toFixed(2));
	$('#total-plus-gst').val("$" + totalPlusGST.toFixed(2));
}

//Format long date e.g. 22 October 2019
function formatLongDate(date) {
	var months = ["","","","","","","","","","","","",""];
	months[1] = "January";
	months[2] = "Febuary";
	months[3] = "March";
	months[4] = "April";
	months[5] = "May";
	months[6] = "June";
	months[7] = "July";
	months[8] = "August";
	months[9] = "September";
	months[10] = "October";
	months[11] = "November";
	months[12] = "December";
	return addLeadingZero(date.getDate()) + " " + months[date.getMonth() + 1] + " " + date.getFullYear();
}

//Format short date e.g. 2019-10-22
function formatShortDate(date) {
	return date.getFullYear() + "-" + addLeadingZero(date.getMonth() + 1) + "-" + addLeadingZero(date.getDate());
}

//Format 24 hour time e.g. 17:30
function format24hourTime(date) {
	return addLeadingZero(date.getHours()) + ":" + addLeadingZero(date.getMinutes());
}

//Format 12 hour time e.g. 5:30pm
function format12hourTime(date) {
	var hour24 = date.getHours();
	var hour12;
	if (hour24 == 0) {
		hour12 = 12;
	} else if (hour24 < 13) {
		hour12 = hour24;
	} else {
		hour12 = hour24 - 12;
	}
	var amPm;
	if (hour24 < 12) {
		amPm = "am";
	} else {
		amPm = "pm";
	}
	return hour12 + ":" + addLeadingZero(date.getMinutes()) + amPm;
}

//Add leading zero to a number it it is less than 10
function addLeadingZero(number) {
	if (number < 10) {
		return "0" + number;
	} else {
		return "" + number;
	}
}