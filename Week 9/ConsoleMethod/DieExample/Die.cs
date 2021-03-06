﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieExample
{
    /// <summary>
    /// A die
    /// </summary>
    class Die
    {
        #region Fields

        int numSides;
        int topSide;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public Die() : this(6)
        {
        }

        /// <summary>
        /// Constructor with number of sides specified
        /// </summary>
        /// <param name="numSides">number of sides for die</param>
        public Die(int numSides)
        {
            this.numSides = numSides;
            topSide = 1;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the number of sides
        /// </summary>
        public int NumSides
        {
            get { return numSides; }
        }

        /// <summary>
        /// Gets the top side
        /// </summary>
        public int TopSide
        {
            get { return topSide; }
        }

        #endregion
    }
}
