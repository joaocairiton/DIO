$(function() {
	// Define the language strings
	
	var langs = {
		"en": "English",
		"zh-CN": "简体中文",
		"ja-JP": "日本語",
		"ko-KR": "한국어",
		"de-DE": "Deutsch",
		"es-lamr": "Español",
		"fr-FR": "Français",
		"it-IT": "Italiano",
		"pt-BR": "Português"
	}
	
	// Define the default language display order
	
	var order = [
		'en',
		'zh-CN',
		'ja-JP',
		'ko-KR',
		'de-DE',
		'es-lamr',
		'fr-FR',
		'it-IT',
		'pt-BR'
	];
	
	// Cache values from the page
	
	var pagelang = $('html').attr('lang');
	var alternates = $("link[rel='alternate'][hreflang]");
	
	var dropdown = $('.language-dropdown');
	var menu = $('.language-dropdown select');
	
	// If required data exists on page...
	
	if(order.includes(pagelang) && alternates.length > 1 && dropdown.attr('data-lang') !== 'complete') {
		
		// Bubble up the current language
		
		if(order.includes(pagelang)) {
			order.splice(order.indexOf(pagelang), 1);
			order.unshift(pagelang);
		}
		
		// Loop through languages in order
		
		$.each(order, function(index, lang) {
			
			// Locate language tag
			
			alternate = alternates.filter("[hreflang='" + lang + "']");
			
			// If language exists on page...
			
			if(alternate.length > 0) {
				
				// Create a new item for language
				
				var node = $('<option></option>');
				var href = alternate.attr('href');
				
				node.text(langs[lang]);
				node.val(href);
				menu.append(node);
				
				// If language matches current language...
				
				if(lang == pagelang) {
					
					// Set the menu to the current language
					
					menu.val(href);
					
				}
			}
		});
		
		// Add redirect based on language selection
		
		menu.change(function() {
			window.location = $(this).val();
		})
		
		// Swap visible language selector
		
		dropdown.removeClass('hidden').attr('data-lang', 'complete');
	}
});