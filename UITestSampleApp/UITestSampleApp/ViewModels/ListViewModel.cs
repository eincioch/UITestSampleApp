﻿using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UITestSampleApp
{
	public class ListViewModel : BaseViewModel
	{
		#region Fields
		List<ListViewPageData> _dataList;
		#endregion

		#region Constructors
		public ListViewModel()
		{
			//DataList = SampleDataModelFactory.GetSampleData().ToList();
			DataList = App.ListPageData;
		}
		#endregion

		#region Properties
		public List<ListViewPageData> DataList
		{
			get { return _dataList; }
			set { SetProperty(ref _dataList, value); }
		}
		#endregion
	}
}
