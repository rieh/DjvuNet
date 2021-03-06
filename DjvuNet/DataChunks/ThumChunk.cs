// <copyright file="ThumChunk.cs" company="">
// TODO: Update copyright text.
// </copyright>

namespace DjvuNet.DataChunks
{

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ThumChunk : DjvuFormElement, IThumChunk
    {
        #region Public Properties

        #region ChunkType

        public override ChunkType ChunkType
        {
            get { return ChunkType.Thum; }
        }

        #endregion ChunkType

        #endregion Public Properties

        #region Constructors

        public ThumChunk(IDjvuReader reader, IDjvuElement parent, IDjvuDocument document,
            string chunkID = "", long length = 0)
            : base(reader, parent, document, chunkID, length)
        {
        }

        public ThumChunk(IDjvuWriter writer, IDjvuElement parent, long length = 0)
            : base(writer, parent, length)
        {
        }

        #endregion Constructors
    }
}
