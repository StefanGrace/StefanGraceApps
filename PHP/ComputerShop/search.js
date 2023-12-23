// search.js
// Stefan Grace - ITWD7.358 Project 2
// 2021

function searchProducts() {
	
	// Get the string that was typed into the seach box
	searchQuery = document.searchForm.searchBox.value.toLowerCase();
	
	// Get the product listing <tr> elements and store them in an array
	productListings = document.getElementsByClassName("product-listing");
	
	// Loop backwards through the array
	for(var i = productListings.length -1; i >= 0; i--) {
		
		// Make all product listings visable incase there were hidden before
		productListings[i].style.display = "";
		
		// If the product listing does not contain the search string, then hide it
		if (productListings[i].innerHTML.toLowerCase().indexOf(searchQuery) == -1) {
			productListings[i].style.display = "none";
		}		
		
	}
	
}