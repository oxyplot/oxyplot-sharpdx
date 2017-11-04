namespace OxyPlot.SharpDX
{
    using global::SharpDX;
    using global::SharpDX.Direct2D1;

    /// <summary>
    /// Represents clipping settings during rendering.
    /// </summary>
    internal class ClipRectRenderUnit : IRenderUnit
    {
        /// <summary>
        /// Clipping rect to set on a target.
        /// </summary>
        private RectangleF clipRect;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipRectRenderUnit" /> class.
        /// </summary>
        /// <param name="clipRect">The clipping rect.</param>
        public ClipRectRenderUnit(RectangleF clipRect)
        {
            this.clipRect = clipRect;
        }

        /// <summary>
        /// Clips render target to the rect, stored in the current instance.
        /// </summary>
        /// <param name="renderTarget"></param>
        public void Render(RenderTarget renderTarget)
        {
            if (clipRect != RectangleF.Empty)
            {
                renderTarget.PushAxisAlignedClip(clipRect, AntialiasMode.PerPrimitive);
            }
            else
            {
                renderTarget.PopAxisAlignedClip();
            }
        }

        /// <summary>
        /// Checks if current instance bounds intersects with viewport or not.
        /// </summary>
        /// <param name="viewport">The viewport.</param>
        /// <returns>Return <c>True</c> if bounds intersects with viewport, otherwise <c>False</c>.</returns>
        public bool CheckBounds(RectangleF viewport)
        {
            // Clipping operation should always be performed. If it's outside of the viewport it will clip
            // out the entire scene and therefore should still be applied.
            return true;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting
        /// unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            // Neither managed nor unmanaged resources are held - noop
        }
    }
}
