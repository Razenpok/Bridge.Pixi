﻿using Bridge.Html5;

namespace Bridge.Pixi
{
	/// <summary>
	/// A texture stores the information that represents an image. All textures have a base texture.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class BaseTexture
	{
		/// <summary>
		/// Helper function that creates a base texture from the given canvas element.
		/// </summary>
		/// <param name="canvas">The canvas element source of the texture.</param>
		/// <param name="scaleMode">The scale mode of the texture.</param>
		public static extern BaseTexture FromCanvas(CanvasElement canvas, ScaleMode scaleMode);

		/// <summary>
		/// Helper function that creates a base texture from the given image url.
		/// If the image is not in the base texture cache it will be created and loaded.
		/// </summary>
		/// <param name="imageUrl">The image url of the texture.</param>
		/// <param name="crossorigin">Should use anonymous CORS? Defaults to true if the URL is not a data-URI.</param>
		public static extern BaseTexture FromImage(string imageUrl, bool crossorigin = true);

		/// <summary>
		/// Helper function that creates a base texture from the given image url.
		/// If the image is not in the base texture cache it will be created and loaded.
		/// </summary>
		/// <param name="imageUrl">The image url of the texture.</param>
		/// <param name="crossorigin">Should use anonymous CORS? Defaults to true if the URL is not a data-URI.</param>
		/// <param name="scaleMode">The scale mode of the texture.</param>
		public static extern BaseTexture FromImage(string imageUrl, bool crossorigin, ScaleMode scaleMode);

		/// <param name="source">The source object of the texture.</param>
		/// <param name="scaleMode">The scale mode of the texture.</param>
		/// <param name="resolution">The resolution of the texture for devices with different pixel ratios.</param>
		public extern BaseTexture(Any<ImageElement, CanvasElement> source,
			ScaleMode scaleMode, Resolution resolution);

		/// <summary>
		/// Set to true once the base texture has successfully loaded.
		/// This is never true if the underlying source fails to load or has no texture data.
		/// </summary>
		public readonly bool HasLoaded;

		/// <summary>
		/// The height of the base texture set when the image has loaded.
		/// </summary>
		public readonly float Height;

		[Name("imageUrl")]
		public string ImageURL;

		/// <summary>
		/// Set to true if the source is currently loading. If an Image source is loading
		/// the 'loaded' or 'error' event will be dispatched when the operation ends.
		/// An underlying source that is immediately-available bypasses loading entirely.
		/// </summary>
		public readonly bool IsLoading;

		/// <summary>
		/// Set this to true if a mipmap of this texture needs to be generated.
		/// This value needs to be set before the texture is used.
		/// Also the texture must be a power of two size to work.
		/// </summary>
		public bool Mipmap;

		/// <summary>
		/// Controls if RGB channels should be pre-multiplied by Alpha (WebGL only).
		/// </summary>
		public bool PremultipliedAlpha;

		/// <summary>
		/// Used to store the actual height of the source of this texture.
		/// </summary>
		public readonly float RealHeight;

		/// <summary>
		/// Used to store the actual width of the source of this texture.
		/// </summary>
		public readonly float RealWidth;

		/// <summary>
		/// The Resolution of the texture.
		/// </summary>
		public Resolution Resolution;

		/// <summary>
		/// The scale mode to apply when scaling this texture.
		/// </summary>
		public ScaleMode ScaleMode;

		/// <summary>
		/// The image source that is used to create the texture.
		/// </summary>
		public readonly Any<ImageElement, CanvasElement> Source;

		/// <summary>
		/// The width of the base texture set when the image has loaded.
		/// </summary>
		public readonly float Width;

		/// <summary>
		/// Destroys this base texture.
		/// </summary>
		public extern void Destroy();

		/// <summary>
		/// Frees the texture from WebGL memory without destroying this texture object.
		/// This means you can still use the texture later which will upload it to GPU memory again.
		/// </summary>
		public extern void Dispose();

		/// <summary>
		/// Load a source. If the source is not-immediately-available, such as an image that
		/// needs to be downloaded, then the 'loaded' or 'error' event will be dispatched in the
		/// future and hasLoaded will remain false after this call.
		/// </summary>
		/// <param name="source">The source object of the texture.</param>
		protected extern void LoadSource(Any<ImageElement, CanvasElement> source);

		/// <summary>
		/// Updates the texture on all the WebDL renderers, this also assumes the src has changed.
		/// </summary>
		public extern void Update();

		/// <summary>
		/// Changes the source image of the texture. The original source must be an Image element.
		/// </summary>
		/// <param name="newSrc">The path of the image.</param>
		public extern void UpdateSourceImage(string newSrc);
	}
}