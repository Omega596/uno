﻿using Windows.Foundation;

namespace Microsoft.UI.Xaml.Shapes
{
	public partial class Ellipse : Shape
	{
#if __APPLE_UIKIT__ || __SKIA__ || __ANDROID__ || __WASM__
		protected override Size MeasureOverride(Size availableSize) => MeasureRelativeShape(availableSize);
#endif

#if __NETSTD_REFERENCE__
		protected override Size MeasureOverride(Size availableSize) => base.MeasureOverride(availableSize);
		protected override Size ArrangeOverride(Size finalSize) => base.ArrangeOverride(finalSize);
#endif
	}
}
