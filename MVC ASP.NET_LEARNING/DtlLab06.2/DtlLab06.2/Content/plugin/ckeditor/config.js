/**
 * @license Copyright (c) 2003-2017, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see LICENSE.md or http://ckeditor.com/license
 */

CKEDITOR.editorConfig = function( config ) {
	config.language = 'en';
	// config.uiColor = '#AADC6E';
	// cấu hình đường dẫn các loại tệp tin khi finder
	config.filebrowserBrowseUrl = "/Content/ckfinder/ckfinder.html";
	config.filebrowserImageUrl = "/Content/ckfinder/ckfinder.html?type=Images";
	config.filebrowserFlashUrl = "/Content/ckfinder/ckfinder.html?type=Flash";
	config.filebrowserUploadUrl = "/Content/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload & type=Files";
	config.filebrowserImageUploadUrl = "/Content/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload & type=Images";
	config.filebrowserFlashUploadUrl = "/Content/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload & type=Flash";
};
