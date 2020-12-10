'use strict';
jQuery(document).ready(function($) {
	var logic = {
		// initialize events
		init: function() {
			this.sections = $('.expandable')
				.find('h4').click($.proxy(this.onClickSection, this)).end();
		},
		// the onclick event for when a section is clicked to expand or contract
		onClickSection: function(event) {
			var section = $(event.target).closest('section').toggleClass('expanded');
			location.hash = section.hasClass('expanded') ? section.find('h4 a').attr('href') : '';
		},
	};
	logic.init();
});