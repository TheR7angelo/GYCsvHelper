using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace GYCsvHelper.UserControls;

public static class Function
{
    /// <summary>
    /// Finds the visual child.
    /// </summary>
    /// <typeparam name="T">The type of the child item.</typeparam>
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
    
    public static int? GetDepartment()
    {
        var dialog = new Dialog.InputBoxNumeric(minValue:0);
        dialog.ShowDialog();

        var dept = dialog.Value;
        if (!dept.Equals(0)) return dept;
        return null;
    }

    public static string? GetUi(string question)
    {
        var dialog = new Dialog.InputBoxString(question);
        dialog.ShowDialog();

        return dialog.Answer;
    }
}