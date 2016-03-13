﻿using Bridge.Html5;

namespace Bridge.Pixi
{
	[External]
	[IgnoreCast]
	[Namespace("PIXI")]
	public abstract class SystemRenderer
	{
		/// <summary>
		/// Whether the render view should be resized automatically.
		/// </summary>
		public bool AutoResize;

		/// <summary>
		/// The background color to fill if not transparent.
		/// </summary>
		public int BackgroundColor;

		// TODO
		/// <summary>
		/// INTERFACE IS NOT IMPLEMENTED YET.
		/// </summary>
		public object BlendModes;

		/// <summary>
		/// This sets if the CanvasRenderer will clear the canvas or not before the new render pass.
		/// If the scene is NOT transparent Pixi will use a canvas sized FillRect operation every
		/// frame to set the canvas background color. If the scene is transparent Pixi will use ClearRect
		/// to clear the canvas every frame. Disable this by setting this to false.
		/// For example if your game has a canvas filling background image you often don't need this set.
		/// </summary>
		public bool ClearBeforeRender;

		/// <summary>
		/// The height of the canvas view.
		/// </summary>
		public float Height;

		/// <summary>
		/// Whether or not the contents of the stencil buffer is retained after rendering.
		/// </summary>
		public bool PreserveDrawingBuffer;

		/// <summary>
		/// The resolution of the renderer.
		/// </summary>
		public Resolution Resolution;

		/// <summary>
		/// Whether the render view is transparent.
		/// </summary>
		public bool Transparent;

		/// <summary>
		/// The type of the renderer.
		/// </summary>
		public RendererType Type;

		/// <summary>
		/// The canvas element that everything is drawn to.
		/// </summary>
		public CanvasElement View;

		/// <summary>
		/// The width of the canvas view.
		/// </summary>
		public float Width;

		/// <summary>
		/// Removes everything from the renderer.
		/// </summary>
		/// <param name="removeView">Removes the Canvas element from the DOM.</param>
		public extern void Destroy(bool removeView = false);

		/// <summary>
		/// Resizes the canvas view to the specified width and height.
		/// </summary>
		/// <param name="width">The new width of the canvas view.</param>
		/// <param name="height">The new height of the canvas view.</param>
		public extern void Resize(float width, float height);
	}
}