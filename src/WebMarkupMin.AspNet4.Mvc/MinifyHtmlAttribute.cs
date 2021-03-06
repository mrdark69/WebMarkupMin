﻿using WebMarkupMin.AspNet.Common;
using WebMarkupMin.AspNet4.Common;

namespace WebMarkupMin.AspNet4.Mvc
{
	/// <summary>
	/// Represents an attribute, that applies HTML minification to the action result
	/// </summary>
	public sealed class MinifyHtmlAttribute : MinifyMarkupAttribute
	{
		/// <summary>
		/// Constructs a instance of HTML minification attribute
		/// </summary>
		public MinifyHtmlAttribute()
			: base(WebMarkupMinConfiguration.Instance, null)
		{ }


		/// <summary>
		/// Gets a instance of default HTML minification manager
		/// </summary>
		/// <returns>Instance of default HTML minification manager</returns>
		protected override IMarkupMinificationManager GetDefaultMinificationManager()
		{
			return HtmlMinificationManager.Current;
		}
	}
}