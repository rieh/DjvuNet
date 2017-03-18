// <copyright file="DjvmChunk.cs" company="">
// TODO: Update copyright text.
// </copyright>

using DjvuNet.DataChunks.Enums;

namespace DjvuNet.DataChunks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class DjvmChunk : FormChunk
    {
        #region Public Properties

        #region ChunkType

        public override ChunkType ChunkType
        {
            get { return ChunkType.Djvm; }
        }

        #endregion ChunkType

        #endregion Public Properties

        #region Constructors

        public DjvmChunk(DjvuReader reader, IFFChunk parent, DjvuDocument document)
            : base(reader, parent, document)
        {
        }

        #endregion Constructors

        #region Protected Methods

        //protected override void ReadChunkData(DjvuReader reader)
        //{
        //    // Nothing
        //}

        #endregion Protected Methods
    }
}