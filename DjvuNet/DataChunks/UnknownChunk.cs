// <copyright file="UnknownChunk.cs" company="">
// TODO: Update copyright text.
// </copyright>

namespace DjvuNet.DataChunks
{

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class UnknownChunk : DjvuNode
    {
        #region Public Properties

        #region ChunkType

        public override ChunkType ChunkType
        {
            get { return ChunkType.Unknown; }
        }

        #endregion ChunkType

        #region Data

        private IDjvuReader _data;

        /// <summary>
        /// Gets the raw chunk data
        /// </summary>
        public IDjvuReader Data
        {
            get
            {
                if (_data == null)
                {
                    _data = ExtractRawData();
                }

                return _data;
            }
        }

        #endregion Data

        #endregion Public Properties

        #region Constructors

        public UnknownChunk(IDjvuReader reader, IDjvuElement parent, IDjvuDocument document,
            string chunkID = "", long length = 0)
            : base(reader, parent, document, chunkID, length)
        {
            // Nothing
        }

        #endregion Constructors

        #region Public Methods

        #endregion Public Methods

        #region Protected Methods

        public override void ReadData(IDjvuReader reader)
        {
            base.ReadData(reader);
            // TODO use ETW logging here
        }

        #endregion Protected Methods

        #region Private Methods

        /// <summary>
        /// Extracts the raw data from the chunk
        /// </summary>
        /// <returns></returns>
        private IDjvuReader ExtractRawData()
        {
            // Read the data in
            return Reader.CloneReaderToMemory(DataOffset + 4 + 4, Length);
        }

        #endregion Private Methods
    }
}
