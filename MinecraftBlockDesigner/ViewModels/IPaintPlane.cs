﻿using MinecraftBlockDesigner.Graphics;
using System;

namespace MinecraftBlockDesigner.ViewModels
{
    public interface IPaintPlane
    {
        event Action UpdateSuface;
        void PaintZX(IGraphics g);

        void PaintXY(IGraphics g);

        void PaintZY(IGraphics g);
    }
}
