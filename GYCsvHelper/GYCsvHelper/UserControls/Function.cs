using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace GYCsvHelper.UserControls;

public static class Function
{
    /// <summary>
    /// Finds the visual child.
    /// </summary>
    /// <typeparam name="childItem">The type of the child item.</typeparam>
    /// <typeparam name="T"></typeparam>
    /// <param name="obj">The obj.</param>
    /// <returns></returns>
    public static IEnumerable<T> FindVisualChildren<T>(this DependencyObject obj) where T : DependencyObject
    {
        for (var i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
        {
            var child = VisualTreeHelper.GetChild(obj, i);
            if (child is T dependencyObject)
            {
                yield return dependencyObject;
            }
            else
            {
                var childOfChild = FindVisualChildren<T>(child);
                foreach (var subchild in childOfChild)
                {
                    yield return subchild;
                }
            }
        }
    }
}