import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';
import { Router } from '@angular/router';
import { LOCALSTORAGE } from 'src/app/contants/Storage';
import {GradientConfig} from '../../../../app-config';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.scss']
})
export class NavBarComponent implements OnInit {
  public gradientConfig: any;
  public menuClass: boolean;
  public collapseStyle: string;
  public windowWidth: number;

  @Output() onNavCollapse = new EventEmitter();
  @Output() onNavHeaderMobCollapse = new EventEmitter();

  constructor(
    private _router: Router
  ) {
    this.gradientConfig = GradientConfig.config;
    this.menuClass = false;
    this.collapseStyle = 'none';
    this.windowWidth = window.innerWidth;
  }

  ngOnInit() { }

  toggleMobOption() {
    this.menuClass = !this.menuClass;
    this.collapseStyle = (this.menuClass) ? 'block' : 'none';
  }

  navCollapse() {
    if (this.windowWidth >= 992) {
      this.onNavCollapse.emit();
    } else {
      this.onNavHeaderMobCollapse.emit();
    }
  }

  logOut(){
    localStorage.removeItem(LOCALSTORAGE.TOKEN);
    this._router.navigateByUrl('/login')
  }

}
