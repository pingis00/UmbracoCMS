//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.2.0+1b21caa
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
	/// <summary>Dynamic Container</summary>
	[PublishedModel("dynamicContainer")]
	public partial class DynamicContainer : PublishedElementModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "dynamicContainer";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<DynamicContainer, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public DynamicContainer(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Large Screen
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("largeScreen")]
		public virtual string LargeScreen => this.Value<string>(_publishedValueFallback, "largeScreen");

		///<summary>
		/// Large Screen Margin Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("largeScreenMarginBottom")]
		public virtual string LargeScreenMarginBottom => this.Value<string>(_publishedValueFallback, "largeScreenMarginBottom");

		///<summary>
		/// Large Screen Margin Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("largeScreenMarginLeft")]
		public virtual string LargeScreenMarginLeft => this.Value<string>(_publishedValueFallback, "largeScreenMarginLeft");

		///<summary>
		/// Large Screen Margin Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("largeScreenMarginRight")]
		public virtual string LargeScreenMarginRight => this.Value<string>(_publishedValueFallback, "largeScreenMarginRight");

		///<summary>
		/// Large Screen Margin Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("largeScreenMarginTop")]
		public virtual string LargeScreenMarginTop => this.Value<string>(_publishedValueFallback, "largeScreenMarginTop");

		///<summary>
		/// Large Screen Padding Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("largeScreenPaddingBottom")]
		public virtual string LargeScreenPaddingBottom => this.Value<string>(_publishedValueFallback, "largeScreenPaddingBottom");

		///<summary>
		/// Large Screen Padding Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("largeScreenPaddingLeft")]
		public virtual string LargeScreenPaddingLeft => this.Value<string>(_publishedValueFallback, "largeScreenPaddingLeft");

		///<summary>
		/// Large Screen Padding Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("largeScreenPaddingRight")]
		public virtual string LargeScreenPaddingRight => this.Value<string>(_publishedValueFallback, "largeScreenPaddingRight");

		///<summary>
		/// Large Screen Padding Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("largeScreenPaddingTop")]
		public virtual string LargeScreenPaddingTop => this.Value<string>(_publishedValueFallback, "largeScreenPaddingTop");

		///<summary>
		/// Large Screen Text Align
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("largeScreenTextAlign")]
		public virtual string LargeScreenTextAlign => this.Value<string>(_publishedValueFallback, "largeScreenTextAlign");

		///<summary>
		/// Medium Screen
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mediumScreen")]
		public virtual string MediumScreen => this.Value<string>(_publishedValueFallback, "mediumScreen");

		///<summary>
		/// Medium Screen Margin Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mediumScreenMarginBottom")]
		public virtual string MediumScreenMarginBottom => this.Value<string>(_publishedValueFallback, "mediumScreenMarginBottom");

		///<summary>
		/// Medium Screen Margin Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mediumScreenMarginLeft")]
		public virtual string MediumScreenMarginLeft => this.Value<string>(_publishedValueFallback, "mediumScreenMarginLeft");

		///<summary>
		/// Medium Screen Margin Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mediumScreenMarginRight")]
		public virtual string MediumScreenMarginRight => this.Value<string>(_publishedValueFallback, "mediumScreenMarginRight");

		///<summary>
		/// Medium Screen Margin Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mediumScreenMarginTop")]
		public virtual string MediumScreenMarginTop => this.Value<string>(_publishedValueFallback, "mediumScreenMarginTop");

		///<summary>
		/// Medium Screen Padding Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mediumScreenPaddingBottom")]
		public virtual string MediumScreenPaddingBottom => this.Value<string>(_publishedValueFallback, "mediumScreenPaddingBottom");

		///<summary>
		/// Medium Screen Padding Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mediumScreenPaddingLeft")]
		public virtual string MediumScreenPaddingLeft => this.Value<string>(_publishedValueFallback, "mediumScreenPaddingLeft");

		///<summary>
		/// Medium Screen Padding Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mediumScreenPaddingRight")]
		public virtual string MediumScreenPaddingRight => this.Value<string>(_publishedValueFallback, "mediumScreenPaddingRight");

		///<summary>
		/// Medium Screen Padding Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mediumScreenPaddingTop")]
		public virtual string MediumScreenPaddingTop => this.Value<string>(_publishedValueFallback, "mediumScreenPaddingTop");

		///<summary>
		/// Medium Screen Text Align
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mediumScreenTextAlign")]
		public virtual string MediumScreenTextAlign => this.Value<string>(_publishedValueFallback, "mediumScreenTextAlign");

		///<summary>
		/// Mobile Screen
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mobileScreen")]
		public virtual string MobileScreen => this.Value<string>(_publishedValueFallback, "mobileScreen");

		///<summary>
		/// Mobile Screen Margin Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mobileScreenMarginBottom")]
		public virtual string MobileScreenMarginBottom => this.Value<string>(_publishedValueFallback, "mobileScreenMarginBottom");

		///<summary>
		/// Mobile Screen Margin Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mobileScreenMarginLeft")]
		public virtual string MobileScreenMarginLeft => this.Value<string>(_publishedValueFallback, "mobileScreenMarginLeft");

		///<summary>
		/// Mobile Screen Margin Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mobileScreenMarginRight")]
		public virtual string MobileScreenMarginRight => this.Value<string>(_publishedValueFallback, "mobileScreenMarginRight");

		///<summary>
		/// Mobile Screen Margin Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mobileScreenMarginTop")]
		public virtual string MobileScreenMarginTop => this.Value<string>(_publishedValueFallback, "mobileScreenMarginTop");

		///<summary>
		/// Mobile Screen Padding Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mobileScreenPaddingBottom")]
		public virtual string MobileScreenPaddingBottom => this.Value<string>(_publishedValueFallback, "mobileScreenPaddingBottom");

		///<summary>
		/// Mobile Screen Padding Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mobileScreenPaddingLeft")]
		public virtual string MobileScreenPaddingLeft => this.Value<string>(_publishedValueFallback, "mobileScreenPaddingLeft");

		///<summary>
		/// Mobile Screen Padding Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mobileScreenPaddingRight")]
		public virtual string MobileScreenPaddingRight => this.Value<string>(_publishedValueFallback, "mobileScreenPaddingRight");

		///<summary>
		/// Mobile Screen Padding Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mobileScreenPaddingTop")]
		public virtual string MobileScreenPaddingTop => this.Value<string>(_publishedValueFallback, "mobileScreenPaddingTop");

		///<summary>
		/// Mobile Screen Text Align
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mobileScreenTextAlign")]
		public virtual string MobileScreenTextAlign => this.Value<string>(_publishedValueFallback, "mobileScreenTextAlign");

		///<summary>
		/// Small Screen
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("smallScreen")]
		public virtual string SmallScreen => this.Value<string>(_publishedValueFallback, "smallScreen");

		///<summary>
		/// Small Screen Margin Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("smallScreenMarginBottom")]
		public virtual string SmallScreenMarginBottom => this.Value<string>(_publishedValueFallback, "smallScreenMarginBottom");

		///<summary>
		/// Small Screen Margin Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("smallScreenMarginLeft")]
		public virtual string SmallScreenMarginLeft => this.Value<string>(_publishedValueFallback, "smallScreenMarginLeft");

		///<summary>
		/// Small Screen Margin Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("smallScreenMarginRight")]
		public virtual string SmallScreenMarginRight => this.Value<string>(_publishedValueFallback, "smallScreenMarginRight");

		///<summary>
		/// Small Screen Margin Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("smallScreenMarginTop")]
		public virtual string SmallScreenMarginTop => this.Value<string>(_publishedValueFallback, "smallScreenMarginTop");

		///<summary>
		/// Small Screen Padding Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("smallScreenPaddingBottom")]
		public virtual string SmallScreenPaddingBottom => this.Value<string>(_publishedValueFallback, "smallScreenPaddingBottom");

		///<summary>
		/// Small Screen Padding Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("smallScreenPaddingLeft")]
		public virtual string SmallScreenPaddingLeft => this.Value<string>(_publishedValueFallback, "smallScreenPaddingLeft");

		///<summary>
		/// Small Screen Padding Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("smallScreenPaddingRight")]
		public virtual string SmallScreenPaddingRight => this.Value<string>(_publishedValueFallback, "smallScreenPaddingRight");

		///<summary>
		/// Small Screen Padding Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("smallScreenPaddingTop")]
		public virtual string SmallScreenPaddingTop => this.Value<string>(_publishedValueFallback, "smallScreenPaddingTop");

		///<summary>
		/// Small Screen Text Align
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("smallScreenTextAlign")]
		public virtual string SmallScreenTextAlign => this.Value<string>(_publishedValueFallback, "smallScreenTextAlign");

		///<summary>
		/// Use Responsive Text Align
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[ImplementPropertyType("useResponsiveTextAlign")]
		public virtual bool UseResponsiveTextAlign => this.Value<bool>(_publishedValueFallback, "useResponsiveTextAlign");

		///<summary>
		/// Use Responsive Width
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[ImplementPropertyType("useResponsiveWidth")]
		public virtual bool UseResponsiveWidth => this.Value<bool>(_publishedValueFallback, "useResponsiveWidth");

		///<summary>
		/// XL Screen
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xlScreen")]
		public virtual string XlScreen => this.Value<string>(_publishedValueFallback, "xlScreen");

		///<summary>
		/// XL Screen Margin Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xlScreenMarginBottom")]
		public virtual string XlScreenMarginBottom => this.Value<string>(_publishedValueFallback, "xlScreenMarginBottom");

		///<summary>
		/// XL Screen Margin Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xlScreenMarginLeft")]
		public virtual string XlScreenMarginLeft => this.Value<string>(_publishedValueFallback, "xlScreenMarginLeft");

		///<summary>
		/// XL Screen Margin Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xlScreenMarginRight")]
		public virtual string XlScreenMarginRight => this.Value<string>(_publishedValueFallback, "xlScreenMarginRight");

		///<summary>
		/// XL Screen Margin Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xlScreenMarginTop")]
		public virtual string XlScreenMarginTop => this.Value<string>(_publishedValueFallback, "xlScreenMarginTop");

		///<summary>
		/// XL Screen Padding Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xlScreenPaddingBottom")]
		public virtual string XlScreenPaddingBottom => this.Value<string>(_publishedValueFallback, "xlScreenPaddingBottom");

		///<summary>
		/// XL Screen Padding Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xlScreenPaddingLeft")]
		public virtual string XlScreenPaddingLeft => this.Value<string>(_publishedValueFallback, "xlScreenPaddingLeft");

		///<summary>
		/// XL Screen Padding Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xlScreenPaddingRight")]
		public virtual string XlScreenPaddingRight => this.Value<string>(_publishedValueFallback, "xlScreenPaddingRight");

		///<summary>
		/// XL Screen Padding Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xlScreenPaddingTop")]
		public virtual string XlScreenPaddingTop => this.Value<string>(_publishedValueFallback, "xlScreenPaddingTop");

		///<summary>
		/// XL Screen Text Align
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xlScreenTextAlign")]
		public virtual string XlScreenTextAlign => this.Value<string>(_publishedValueFallback, "xlScreenTextAlign");

		///<summary>
		/// XXL Screen
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xxlScreen")]
		public virtual string XxlScreen => this.Value<string>(_publishedValueFallback, "xxlScreen");

		///<summary>
		/// XXL Screen Margin Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xxlScreenMarginBottom")]
		public virtual string XxlScreenMarginBottom => this.Value<string>(_publishedValueFallback, "xxlScreenMarginBottom");

		///<summary>
		/// XXL Screen Margin Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xxlScreenMarginLeft")]
		public virtual string XxlScreenMarginLeft => this.Value<string>(_publishedValueFallback, "xxlScreenMarginLeft");

		///<summary>
		/// XXL Screen Margin Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xxlScreenMarginRight")]
		public virtual string XxlScreenMarginRight => this.Value<string>(_publishedValueFallback, "xxlScreenMarginRight");

		///<summary>
		/// XXL Screen Margin Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xxlScreenMarginTop")]
		public virtual string XxlScreenMarginTop => this.Value<string>(_publishedValueFallback, "xxlScreenMarginTop");

		///<summary>
		/// XXL Screen Padding Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xxlScreenPaddingBottom")]
		public virtual string XxlScreenPaddingBottom => this.Value<string>(_publishedValueFallback, "xxlScreenPaddingBottom");

		///<summary>
		/// XXL Screen Padding Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xxlScreenPaddingLeft")]
		public virtual string XxlScreenPaddingLeft => this.Value<string>(_publishedValueFallback, "xxlScreenPaddingLeft");

		///<summary>
		/// XXL Screen Padding Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xxlScreenPaddingRight")]
		public virtual string XxlScreenPaddingRight => this.Value<string>(_publishedValueFallback, "xxlScreenPaddingRight");

		///<summary>
		/// XXL Screen Padding Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xxlScreenPaddingTop")]
		public virtual string XxlScreenPaddingTop => this.Value<string>(_publishedValueFallback, "xxlScreenPaddingTop");

		///<summary>
		/// XXL Screen Text Align
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xxlScreenTextAlign")]
		public virtual string XxlScreenTextAlign => this.Value<string>(_publishedValueFallback, "xxlScreenTextAlign");
	}
}
