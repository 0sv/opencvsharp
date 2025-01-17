﻿using System;
using System.Runtime.InteropServices;

namespace OpenCvSharp.CPlusPlus
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Rect : IEquatable<Rect>
    {
        #region Field
        /// <summary>
        /// 
        /// </summary>
        public int X;
        /// <summary>
        /// 
        /// </summary>
        public int Y;
        /// <summary>
        /// 
        /// </summary>
        public int Width;
        /// <summary>
        /// 
        /// </summary>
        public int Height;
        /// <summary>
        /// sizeof(Rect)
        /// </summary>
        public const int SizeOf = sizeof(int) * 4;

#if LANG_JP
        /// <summary>
        /// プロパティを初期化しない状態の CvRect 構造体を表します。 
        /// </summary>
#else
        /// <summary>
        /// Represents a CvRect structure with its properties left uninitialized. 
        /// </summary>
#endif
        public static readonly Rect Empty = new Rect();
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Rect(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="location"></param>
        /// <param name="size"></param>
        public Rect(Point location, Size size)
        {
            X = location.X;
            Y = location.Y;
            Width = size.Width;
            Height = size.Height;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        public static Rect FromLTRB(int left, int top, int right, int bottom)
        {
            Rect r = new Rect
            {
                X = left,
                Y = top,
                Width = right - left,
                Height = bottom - top
            };

            if (r.Width < 0)
                throw new ArgumentException("right > left");
            if (r.Width < 0)
                throw new ArgumentException("bottom > top");
            return r;
        }

        #region Cast
        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static implicit operator CvRect(Rect self)
        {
            return new CvRect(self.X, self.Y, self.Width, self.Height);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rect"></param>
        /// <returns></returns>
        public static implicit operator Rect(CvRect rect)
        {
            return new Rect(rect.X, rect.Y, rect.Width, rect.Height);
        }
        #endregion

        #region Operators
        #region == / !=
#if LANG_JP
        /// <summary>
        /// 指定したオブジェクトと等しければtrueを返す 
        /// </summary>
        /// <param name="obj">比較するオブジェクト</param>
        /// <returns>型が同じで、メンバの値が等しければtrue</returns>
#else
        /// <summary>
        /// Specifies whether this object contains the same members as the specified Object.
        /// </summary>
        /// <param name="obj">The Object to test.</param>
        /// <returns>This method returns true if obj is the same type as this object and has the same members as this object.</returns>
#endif
        public bool Equals(Rect obj)
        {
            return (X == obj.X && Y == obj.Y && Width == obj.Width && Height == obj.Height);
        }
#if LANG_JP
        /// <summary>
        /// == 演算子のオーバーロード
        /// </summary>
        /// <param name="lhs">左辺値</param>
        /// <param name="rhs">右辺値</param>
        /// <returns>等しければtrue</returns>
#else
        /// <summary>
        /// Compares two CvPoint objects. The result specifies whether the members of each object are equal.
        /// </summary>
        /// <param name="lhs">A Point to compare.</param>
        /// <param name="rhs">A Point to compare.</param>
        /// <returns>This operator returns true if the members of left and right are equal; otherwise, false.</returns>
#endif
        public static bool operator ==(Rect lhs, Rect rhs)
        {
            return lhs.Equals(rhs);
        }
#if LANG_JP
        /// <summary>
        /// != 演算子のオーバーロード
        /// </summary>
        /// <param name="lhs">左辺値</param>
        /// <param name="rhs">右辺値</param>
        /// <returns>等しくなければtrue</returns>
#else
        /// <summary>
        /// Compares two CvPoint objects. The result specifies whether the members of each object are unequal.
        /// </summary>
        /// <param name="lhs">A Point to compare.</param>
        /// <param name="rhs">A Point to compare.</param>
        /// <returns>This operator returns true if the members of left and right are unequal; otherwise, false.</returns>
#endif
        public static bool operator !=(Rect lhs, Rect rhs)
        {
            return !lhs.Equals(rhs);
        }
        #endregion
        #region + / -
#if LANG_JP
        /// <summary>
        /// あるオフセットで矩形を移動させる
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="pt"></param>
        /// <returns></returns>
#else
        /// <summary>
        /// Shifts rectangle by a certain offset
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="pt"></param>
        /// <returns></returns>
#endif
        public static Rect operator +(Rect rect, Point pt)
        {
            return new Rect(rect.X + pt.X, rect.Y + pt.Y, rect.Width, rect.Height);
        }
#if LANG_JP
        /// <summary>
        /// あるオフセットで矩形を移動させる
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="pt"></param>
        /// <returns></returns>
#else
        /// <summary>
        /// Shifts rectangle by a certain offset
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="pt"></param>
        /// <returns></returns>
#endif
        public static Rect operator -(Rect rect, Point pt)
        {
            return new Rect(rect.X - pt.X, rect.Y - pt.Y, rect.Width, rect.Height);
        }

#if LANG_JP
        /// <summary>
        /// 指定したサイズ応じて、矩形を膨張または縮小する
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="size"></param>
        /// <returns></returns>
#else
        /// <summary>
        /// Expands or shrinks rectangle by a certain amount
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="size"></param>
        /// <returns></returns>
#endif
        public static Rect operator +(Rect rect, Size size)
        {
            return new Rect(rect.X, rect.Y, rect.Width + size.Width, rect.Height + size.Height);
        }
#if LANG_JP
        /// <summary>
        /// 指定したサイズ応じて、矩形を膨張または縮小する
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="size"></param>
        /// <returns></returns>
#else
        /// <summary>
        /// Expands or shrinks rectangle by a certain amount
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="size"></param>
        /// <returns></returns>
#endif
        public static Rect operator -(Rect rect, Size size)
        {
            return new Rect(rect.X, rect.Y, rect.Width - size.Width, rect.Height - size.Height);
        }
        #endregion
        #region & / |
#if LANG_JP
        /// <summary>
        /// 2つの矩形の交差部分を表す矩形を取得する
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
#else
        /// <summary>
        /// Determines the CvRect structure that represents the intersection of two rectangles. 
        /// </summary>
        /// <param name="a">A rectangle to intersect. </param>
        /// <param name="b">A rectangle to intersect. </param>
        /// <returns></returns>
#endif
        public static Rect operator &(Rect a, Rect b)
        {
            return Intersect(a, b);
        }

#if LANG_JP
        /// <summary>
        /// 2つの矩形の和集合を表す矩形を取得する 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
#else
        /// <summary>
        /// Gets a CvRect structure that contains the union of two CvRect structures. 
        /// </summary>
        /// <param name="a">A rectangle to union. </param>
        /// <param name="b">A rectangle to union. </param>
        /// <returns></returns>
#endif
        public static Rect operator |(Rect a, Rect b)
        {
            return Union(a, b);
        }
        #endregion
        #endregion

        #region Properties
#if LANG_JP
        /// <summary>
        /// 上端のy座標 
        /// </summary>
#else
        /// <summary>
        /// Gets the y-coordinate of the top edge of this CvRect structure. 
        /// </summary>
#endif
        public int Top
        {
            get { return Y; }
            set { Y = value; }
        }
#if LANG_JP
        /// <summary>
        /// 下端のy座標 (Y + Height) 
        /// </summary>
#else
        /// <summary>
        /// Gets the y-coordinate that is the sum of the Y and Height property values of this CvRect structure.
        /// </summary>
#endif
        public int Bottom
        {
            get { return Y + Height - 1; }
        }
#if LANG_JP
        /// <summary>
        /// 左端のx座標
        /// </summary>
#else
        /// <summary>
        /// Gets the x-coordinate of the left edge of this CvRect structure. 
        /// </summary>
#endif
        public int Left
        {
            get { return X; }
            set { X = value; }
        }
#if LANG_JP
        /// <summary>
        /// 右端のx座標 (X + Width)
        /// </summary>
#else
        /// <summary>
        /// Gets the x-coordinate that is the sum of X and Width property values of this CvRect structure. 
        /// </summary>
#endif
        public int Right
        {
            get { return X + Width - 1; }
        }

#if LANG_JP
        /// <summary>
        /// 矩形の左上頂点の位置 [CvPoint(X, Y)]
        /// </summary>
#else
        /// <summary>
        /// Coordinate of the left-most rectangle corner [CvPoint(X, Y)]
        /// </summary>
#endif
        public Point Location
        {
            get { return new Point(X, Y); }
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }
#if LANG_JP
        /// <summary>
        /// 矩形の大きさ [CvSize(Width, Height)]
        /// </summary>
#else
        /// <summary>
        /// Size of the rectangle [CvSize(Width, Height)]
        /// </summary>
#endif
        public Size Size
        {
            get { return new Size(Width, Height); }
            set
            {
                Width = value.Width;
                Height = value.Height;
            }
        }

#if LANG_JP
        /// <summary>
        /// 左上の頂点
        /// </summary>
#else
        /// <summary>
        /// Coordinate of the left-most rectangle corner [CvPoint(X, Y)]
        /// </summary>
#endif
        public Point TopLeft
        {
            get { return new Point(X, Y); }
        }
#if LANG_JP
        /// <summary>
        /// 右下の頂点
        /// </summary>
#else
        /// <summary>
        /// Coordinate of the right-most rectangle corner [CvPoint(X+Width, Y+Height)]
        /// </summary>
#endif
        public Point BottomRight
        {
            get { return new Point(X + Width, Y + Height); }
        }
        #endregion

        #region Methods
#if LANG_JP
        /// <summary>
        /// 指定した点がこの矩形に含まれているかどうかを判断する
        /// </summary>
        /// <param name="x">x座標</param>
        /// <param name="y">y座標</param>
        /// <returns></returns>
#else
        /// <summary>
        /// Determines if the specified point is contained within the rectangular region defined by this Rectangle. 
        /// </summary>
        /// <param name="x">x-coordinate of the point</param>
        /// <param name="y">y-coordinate of the point</param>
        /// <returns></returns>
#endif
        public bool Contains(int x, int y)
        {
            return (X <= x && Y <= y && X + Width > x && Y + Height > y);
        }
#if LANG_JP
        /// <summary>
        /// 指定した点がこの矩形に含まれているかどうかを判断する
        /// </summary>
        /// <param name="pt">点</param>
        /// <returns></returns>
#else
        /// <summary>
        /// Determines if the specified point is contained within the rectangular region defined by this Rectangle. 
        /// </summary>
        /// <param name="pt">point</param>
        /// <returns></returns>
#endif
        public bool Contains(Point pt)
        {
            return Contains(pt.X, pt.Y);
        }
#if LANG_JP
        /// <summary>
        /// 指定した矩形がこの矩形に含まれているかどうかを判断する
        /// </summary>
        /// <param name="rect">矩形</param>
        /// <returns></returns>
#else
        /// <summary>
        /// Determines if the specified rectangle is contained within the rectangular region defined by this Rectangle. 
        /// </summary>
        /// <param name="rect">rectangle</param>
        /// <returns></returns>
#endif
        public bool Contains(Rect rect)
        {
            return Contains(rect.TopLeft) && Contains(rect.BottomRight);
        }

#if LANG_JP
        /// <summary>
        /// このCvRectを指定の量だけ膨らませる 
        /// </summary>
        /// <param name="width">水平方向の膨張量</param>
        /// <param name="height">垂直方向の膨張量</param>
#else
        /// <summary>
        /// Inflates this CvRect by the specified amount. 
        /// </summary>
        /// <param name="width">The amount to inflate this Rectangle horizontally. </param>
        /// <param name="height">The amount to inflate this Rectangle vertically. </param>
#endif
        public void Inflate(int width, int height)
        {
            X -= width;
            Y -= height;
            Width += (2 * width);
            Height += (2 * height);
        }
#if LANG_JP
        /// <summary>
        /// このCvRectを指定の量だけ膨らませる 
        /// </summary>
        /// <param name="size">この四角形の膨張量</param>
#else
        /// <summary>
        /// Inflates this CvRect by the specified amount. 
        /// </summary>
        /// <param name="size">The amount to inflate this rectangle. </param>
#endif
        public void Inflate(Size size)
        {

            Inflate(size.Width, size.Height);
        }
#if LANG_JP
        /// <summary>
        /// このCvRectを指定の量だけ膨らませる 
        /// </summary>
        /// <param name="rect">対象の矩形</param>
        /// <param name="x">水平方向の膨張量</param>
        /// <param name="y">垂直方向の膨張量</param>
        /// <returns></returns>
#else
        /// <summary>
        /// Creates and returns an inflated copy of the specified CvRect structure.
        /// </summary>
        /// <param name="rect">The Rectangle with which to start. This rectangle is not modified. </param>
        /// <param name="x">The amount to inflate this Rectangle horizontally. </param>
        /// <param name="y">The amount to inflate this Rectangle vertically. </param>
        /// <returns></returns>
#endif
        public static Rect Inflate(Rect rect, int x, int y)
        {
            rect.Inflate(x, y);
            return rect;
        }

#if LANG_JP
        /// <summary>
        /// 2つの矩形の交差部分を表す矩形を取得する
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
#else
        /// <summary>
        /// Determines the CvRect structure that represents the intersection of two rectangles. 
        /// </summary>
        /// <param name="a">A rectangle to intersect. </param>
        /// <param name="b">A rectangle to intersect. </param>
        /// <returns></returns>
#endif
        public static Rect Intersect(Rect a, Rect b)
        {
            int x1 = Math.Max(a.X, b.X);
            int x2 = Math.Min(a.X + a.Width, b.X + b.Width);
            int y1 = Math.Max(a.Y, b.Y);
            int y2 = Math.Min(a.Y + a.Height, b.Y + b.Height);

            if (x2 >= x1 && y2 >= y1)
                return new Rect(x1, y1, x2 - x1, y2 - y1);
            return Empty;
        }
#if LANG_JP
        /// <summary>
        /// 2 つの矩形の交差部分を表す矩形を取得する
        /// </summary>
        /// <param name="rect"></param>
        /// <returns></returns>
#else
        /// <summary>
        /// Determines the CvRect structure that represents the intersection of two rectangles. 
        /// </summary>
        /// <param name="rect">A rectangle to intersect. </param>
        /// <returns></returns>
#endif
        public Rect Intersect(Rect rect)
        {
            return Intersect(this, rect);
        }

#if LANG_JP
        /// <summary>
        /// 指定した矩形がこの矩形と交差するかどうか判定する
        /// </summary>
        /// <param name="rect">矩形</param>
        /// <returns></returns>
#else
        /// <summary>
        /// Determines if this rectangle intersects with rect. 
        /// </summary>
        /// <param name="rect">Rectangle</param>
        /// <returns></returns>
#endif
        public bool IntersectsWith(Rect rect)
        {
            return (
                (X < rect.X + rect.Width) &&
                (X + Width > rect.X) &&
                (Y < rect.Y + rect.Height) &&
                (Y + Height > rect.Y)
            );
        }

#if LANG_JP
        /// <summary>
        /// 2つの矩形の和集合を表す矩形を取得する 
        /// </summary>
        /// <param name="rect"></param>
        /// <returns></returns>
#else
        /// <summary>
        /// Gets a CvRect structure that contains the union of two CvRect structures. 
        /// </summary>
        /// <param name="rect">A rectangle to union. </param>
        /// <returns></returns>
#endif
        public Rect Union(Rect rect)
        {
            return Union(this, rect);
        }
#if LANG_JP
        /// <summary>
        /// 2つの矩形の和集合を表す矩形を取得する 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
#else
        /// <summary>
        /// Gets a CvRect structure that contains the union of two CvRect structures. 
        /// </summary>
        /// <param name="a">A rectangle to union. </param>
        /// <param name="b">A rectangle to union. </param>
        /// <returns></returns>
#endif
        public static Rect Union(Rect a, Rect b)
        {
            int x1 = Math.Min(a.X, b.X);
            int x2 = Math.Max(a.X + a.Width, b.X + b.Width);
            int y1 = Math.Min(a.Y, b.Y);
            int y2 = Math.Max(a.Y + a.Height, b.Y + b.Height);

            return new Rect(x1, y1, x2 - x1, y2 - y1);
        }

#if LANG_JP
        /// <summary>
        /// Equalsのオーバーライド
        /// </summary>
        /// <param name="obj">比較するオブジェクト</param>
        /// <returns></returns>
#else
        /// <summary>
        /// Specifies whether this object contains the same members as the specified Object.
        /// </summary>
        /// <param name="obj">The Object to test.</param>
        /// <returns>This method returns true if obj is the same type as this object and has the same members as this object.</returns>
#endif
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
#if LANG_JP
        /// <summary>
        /// GetHashCodeのオーバーライド
        /// </summary>
        /// <returns>このオブジェクトのハッシュ値を指定する整数値。</returns>
#else
        /// <summary>
        /// Returns a hash code for this object.
        /// </summary>
        /// <returns>An integer value that specifies a hash value for this object.</returns>
#endif
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Width.GetHashCode() ^ Height.GetHashCode();
        }
#if LANG_JP
        /// <summary>
        /// 文字列形式を返す 
        /// </summary>
        /// <returns>文字列形式</returns>
#else
        /// <summary>
        /// Converts this object to a human readable string.
        /// </summary>
        /// <returns>A string that represents this object.</returns>
#endif
        public override string ToString()
        {
            return string.Format("(x:{0} y:{1} width:{2} height:{3})", X, Y, Width, Height);
        }

        #endregion
    }
}
