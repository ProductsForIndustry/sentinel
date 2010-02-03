#region License
//
// � Copyright Ray Hayes
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.
//
#endregion

#region Using directives

using System.Collections.ObjectModel;
using System.Windows.Input;

#endregion

namespace Sentinel.Classifying
{

    #region Using directives

    #endregion

    public interface IClassifierService
    {
        ICommand Add { get; }

        ICommand Edit { get; }

        ObservableCollection<IClassifier> Items { get; }

        ICommand OrderEarlier { get; }

        ICommand OrderLater { get; }

        ICommand Remove { get; }

        int SelectedIndex { get; set; }
    }
}