﻿using System;

namespace Microsoft.Maui.Controls
{
	[AttributeUsage(AttributeTargets.Class)]
	public class RouteAttribute : Attribute
	{
		public RouteAttribute() { }

		public RouteAttribute(string route, ServiceScope scope = ServiceScope.Singleton) => (Route, Scope) = (route, scope);

		public string? Route { get; }

		/// <summary>
		/// Routes of the View (page) type on which this attribute is defined
		/// When both Routes and Route properties are defined, Routes takes precedence
		/// </summary>
		public string[]? Routes { get; set; }

		/// <summary>
		/// Scope of the View (page) / ViewModel type on which this attribute is defined
		/// </summary>
		public ServiceScope Scope { get; set; }

		/// <summary>
		/// Indicates whether the ViewModel should be associated automatically.
		/// </summary>
		public bool ImplicitViewModel { get; set; }

		/// <summary>
		/// Type of the ViewModel associated with the View (page) on which this attribute is defined
		/// When both ImplicitViewModel and ViewModelType properties are defined, ViewModelType takes precedence.
		/// </summary>
		public Type? ViewModelType { get; set; }
	}
}
