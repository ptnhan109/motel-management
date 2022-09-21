import {Injectable} from '@angular/core';

export interface NavigationItem {
  id: string;
  title: string;
  type: 'item' | 'collapse' | 'group';
  translate?: string;
  icon?: string;
  hidden?: boolean;
  url?: string;
  classes?: string;
  exactMatch?: boolean;
  external?: boolean;
  target?: boolean;
  breadcrumbs?: boolean;
  function?: any;
  badge?: {
    title?: string;
    type?: string;
  };
  children?: Navigation[];
}

export interface Navigation extends NavigationItem {
  children?: NavigationItem[];
}

const NavigationItems = [
  {
    id: 'navigation',
    title: 'Navigation',
    type: 'group',
    icon: 'feather icon-monitor',
    children: [
      {
        id: 'dashboard',
        title: 'Quản trị',
        type: 'item',
        url: '/dashboard',
        icon: 'feather icon-home',
        breadcrumbs: false
      },
      {
        id: 'category',
        title: 'Danh mục',
        type: 'collapse',
        icon: 'feather icon-layout',
        children: [
          {
            id: 'service',
            title: 'Dịch vụ',
            type: 'item',
            url: '/service',
            breadcrumbs: false
          },
          {
            id: 'fitment',
            title: 'Tiện ích',
            type: 'item',
            url: '/fitment'
          }
        ]
      },
      {
        id: 'boarding',
        title: 'Khu trọ',
        type: 'item',
        url: '/boarding-house',
        icon: 'feather icon-aperture',
        breadcrumbs: false
      },
    ]
  }
];

@Injectable()
export class NavigationItem {
  public get() {
    return NavigationItems;
  }
}
