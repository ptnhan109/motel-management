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
        id: 'report',
        title: 'Báo cáo',
        type: 'item',
        url: '/report',
        icon: 'feather icon-inbox',
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
            title: 'Thiết bị',
            type: 'item',
            url: '/fitment',
            breadcrumbs: false
          }
        ]
      },
      {
        id: 'boarding',
        title: 'Khu trọ',
        type: 'collapse',
        icon: 'feather icon-server',
        children: [
          {
            id: 'boardings',
            title: 'Khu trọ',
            type: 'item',
            url: '/boarding-house',
            breadcrumbs: false
          },
          {
            id: 'rooms',
            title: 'Phòng trọ',
            type: 'item',
            url: '/room',
            breadcrumbs: false
          }
        ]
      },
      {
        id: 'contract',
        title: 'Hợp đồng',
        type: 'item',
        url: '/contracts',
        icon: 'feather icon-box',
        breadcrumbs: false,
      },
      {
        id: 'invoice',
        title: 'Hóa đơn',
        type: 'item',
        url: '/invoice',
        icon: 'feather icon-disc',
        breadcrumbs: false
      },
      {
        id: 'customers',
        title: 'Khách hàng',
        type: 'collapse',
        url: '#',
        icon: 'feather icon-users',
        breadcrumbs: false,
        children: [
          {
            id: 'customers',
            title: 'Khách thuê',
            type: 'item',
            url: '/customers',
            breadcrumbs: false
          },
          {
            id: 'vehicles',
            title: 'Phương tiện',
            type: 'item',
            url: '/vehicles',
            breadcrumbs: false
          }
        ]
      },
      {
        id: 'aftereffect',
        title: 'Phản ánh',
        type: 'item',
        url: '/contract',
        icon: 'feather icon-layers',
        breadcrumbs: false
      },
      {
        id: 'system',
        title: 'Hệ thống',
        type: 'item',
        url: '/system',
        icon: 'feather icon-settings',
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
