using System;

namespace DeckSwipe.CardModel.Import {

    [Serializable]
    public class ProtoImage {

        public int id;                // ID unik gambar
        public string localPath;      // Path ke file lokal

        public ProtoImage(int id, string localPath) {
            this.id = id;
            this.localPath = localPath;
        }
    }
}
