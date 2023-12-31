﻿using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;
using MvvmCross.Platforms.Mac.Binding.Views;
using ObjCRuntime;

namespace TipCalc.UI.Mac
{
	public partial class TipView : MvxView
	{
		#region Constructors

		// Called when created from unmanaged code
		public TipView(NativeHandle handle) : base(handle)
		{
			Initialize();
		}

		// Called when created directly from a XIB file
		[Export("initWithCoder:")]
		public TipView(NSCoder coder) : base(coder)
		{
			Initialize();
		}

		// Shared initialization code
		void Initialize()
		{
		}

		#endregion
	}
}
