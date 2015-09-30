﻿//
//  Copyright 2015  Xamarin Inc.
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
using XamarinCRM.Cells;
using Xamarin.Forms;
using XamarinCRM.Views.Base;
using XamarinCRM.Statics;

namespace XamarinCRM.Views.Products
{
    public class CategoryListView : BaseNonPersistentSelectedItemListView
    {
        public CategoryListView()
        {
            ItemTemplate = new DataTemplate(typeof(CategoryListItemCell));
            RowHeight = (int)Sizes.LargeRowHeight;
            SeparatorVisibility = SeparatorVisibility.Default;
            SeparatorColor = Palette._013;
        }
    }
}


