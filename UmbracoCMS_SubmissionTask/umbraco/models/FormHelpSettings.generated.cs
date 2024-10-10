//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.3.0+32c00f9
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Form Help Settings</summary>
	[PublishedModel("formHelpSettings")]
	public partial class FormHelpSettings : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		public new const string ModelTypeAlias = "formHelpSettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<FormHelpSettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public FormHelpSettings(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Background Color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("backgroundColor")]
		public virtual global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor BackgroundColor => this.Value<global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor>(_publishedValueFallback, "backgroundColor");

		///<summary>
		/// Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headline")]
		public virtual string Headline => this.Value<string>(_publishedValueFallback, "headline");

		///<summary>
		/// Headline Color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headlineColor")]
		public virtual global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor HeadlineColor => this.Value<global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor>(_publishedValueFallback, "headlineColor");

		///<summary>
		/// Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("text")]
		public virtual string Text => this.Value<string>(_publishedValueFallback, "text");

		///<summary>
		/// Text Color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("textColor")]
		public virtual global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor TextColor => this.Value<global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor>(_publishedValueFallback, "textColor");
	}
}
