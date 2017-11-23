using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shorka
{

    public enum DebugColors
    {
        aqua,
        black,
        blue,
        brown,
        cyan,
        darkblue,
        fuchsia,
        green,
        grey,
        lightblue,
        lime,
        magenta,
        maroon,
        navy,
        olive,
        purple,
        red,
        silver,
        teal,
        white,
        yellow
    }

    public static class DebugHelper 
    {

        /// <summary>
        /// Sets the color of the text according to the parameter value.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="color">Color.</param>
        public static string StrColored(this string message, DebugColors color)
        {
            return string.Format("<color={0}>{1}</color>", color.ToString(), message);
        }

        /// <summary>
        /// Sets the size of the text according to the parameter value, given in pixels.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="size">Size.</param>
        public static string StrSized(this string message, int size)
        {
            return string.Format("<size={0}>{1}</size>", size, message);
        }

        /// <summary>
        /// Renders the text in boldface.
        /// </summary>
        /// <param name="message">Message.</param>
        public static string StrBold(this string message)
        {
            return string.Format("<b>{0}</b>", message);
        }

        /// <summary>
        /// Renders the text in italics.
        /// </summary>
        /// <param name="message">Message.</param>
        public static string StrItalics(this string message)
        {
            return string.Format("<i>{0}</i>", message);
        }
    }

}

