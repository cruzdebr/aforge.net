// AForge Core Library
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright � Andrew Kirillov, 2007-2009
// andrew.kirillov@aforgenet.com
//
// Copyright � Fabio L. Caversan, 2008
// fabio.caversan@gmail.com
//

namespace AForge
{
    using System;

    /// <summary>
    /// Class for representing a pair of coordinates of double type.
    /// </summary>
    /// 
    /// <remarks><para>The class is used to store a pair of floating point
    /// coordinates with double precision.</para>
    /// 
    /// <para>Sample usage:</para>
    /// <code>
    /// // assigning coordinates in the constructor
    /// DoublePoint p1 = new DoublePoint( 10, 20 );
    /// // creating a point and assigning coordinates later
    /// DoublePoint p2;
    /// p2.X = 30;
    /// p2.Y = 40;
    /// // calculating distance between two points
    /// double distance = p1.DistanceTo( p2 );
    /// </code>
    /// </remarks>
    /// 
    public struct DoublePoint
    {
        /// <summary> 
        /// X coordinate.
        /// </summary> 
        /// 
        public double X;

        /// <summary> 
        /// Y coordinate.
        /// </summary> 
        /// 
        public double Y;

        /// <summary>
        /// Initializes a new instance of the <see cref="DoublePoint"/> structure.
        /// </summary>
        /// 
        /// <param name="x">X axis coordinate.</param>
        /// <param name="y">Y axis coordinate.</param>
        /// 
        public DoublePoint( double x, double y )
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Calculate Euclidean distance between two points.
        /// </summary>
        /// 
        /// <param name="anotherPoint">Point to calculate distance to.</param>
        /// 
        /// <returns>Returns Euclidean distance between this point and
        /// <paramref name="anotherPoint"/> points.</returns>
        /// 
        public double DistanceTo( IntPoint anotherPoint )
        {
            double dx = X - anotherPoint.X;
            double dy = Y - anotherPoint.Y;

            return System.Math.Sqrt( dx * dx + dy * dy );
        }
    }
}
