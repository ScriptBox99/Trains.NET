﻿using Trains.NET.Engine;

namespace Trains.NET.Rendering
{
    [Order(15)]
    internal class TreeTool : ITool
    {
        private readonly IStaticEntityCollection _entityCollection;

        public ToolMode Mode => ToolMode.Build;
        public string Name => "Tree";

        public TreeTool(IStaticEntityCollection trackLayout)
        {
            _entityCollection = trackLayout;
        }

        public void Execute(int column, int row)
        {
            _entityCollection.Add(column, row, new Tree());
        }

        public bool IsValid(int column, int row) => _entityCollection.IsEmptyOrT<Tree>(column, row);
    }
}