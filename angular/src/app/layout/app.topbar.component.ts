import { Component, ElementRef, ViewChild } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { LayoutService } from "./service/app.layout.service";
import { AuthService } from '../shared/services/auth.service';
import { Router } from '@angular/router';
import { LOGIN_URL } from '../shared/constants/urls.const';

@Component({
    selector: 'app-topbar',
    templateUrl: './app.topbar.component.html'
})
export class AppTopBarComponent {

    items!: MenuItem[];
    userMenuItems: MenuItem[];

    @ViewChild('menubutton') menuButton!: ElementRef;

    @ViewChild('topbarmenubutton') topbarMenuButton!: ElementRef;

    @ViewChild('topbarmenu') menu!: ElementRef;

    constructor(public layoutService: LayoutService, private authService: AuthService, private router: Router) {}
    ngOnInit(): void {
      this.userMenuItems = [
        {
          label: 'Thông tin cá nhân',
          icon: 'pi pi-id-card',
          routerLink: ['/profile'],
        },
        {
          label: 'Đổi mật khẩu',
          icon: 'pi pi-key',
          routerLink: ['/change-password'],
        },
        {
          label: 'Đăng xuất',
          icon: 'pi pi-sign-out',
          command: event => {
            this.authService.logout();
            this.router.navigate([LOGIN_URL]);
          },
        },
      ];
    }
}
