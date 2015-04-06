﻿namespace MW5.Plugins.Services
{
    public interface ILayerService
    {
        bool AddLayer(DataSourceType layerType);
        bool RemoveSelectedLayer();
        bool AddLayersFromFilename(string filename);
        void ZoomToSelected();
        void ClearSelection();
        int LastLayerHandle { get; }
        void BeginBatch();
        void EndBatch();
        void SaveStyle();
        void LoadStyle();
    }
}
