// <copyright file="InclChunk.cs" company="">
// TODO: Update copyright text.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DjvuNet.DataChunks.Enums;

namespace DjvuNet.DataChunks
{

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class InclChunk : IFFChunk
    {
        #region Public Properties

        #region ChunkType

        public override ChunkType ChunkType
        {
            get { return ChunkType.Incl; }
        }

        #endregion ChunkType

        #region IncludeID

        private string _includeID;

        /// <summary>
        /// Gets the ID of the element to include
        /// </summary>
        public string IncludeID
        {
            get { return _includeID; }

            private set
            {
                if (IncludeID != value)
                {
                    _includeID = value;
                }
            }
        }

        #endregion IncludeID

        #endregion Public Properties

        #region Constructors

        public InclChunk(DjvuReader reader, IFFChunk parent, DjvuDocument document,
            string chunkID = "", long length = 0)
            : base(reader, parent, document, chunkID, length)
        {
        }

        #endregion Constructors

        #region Protected Methods

        protected override void ReadChunkData(DjvuReader reader)
        {
            _includeID = reader.ReadUTF8String(Length);
        }

        #endregion Protected Methods
    }
}