import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AccountService } from '../_services/account.service';
import { NgIf } from '@angular/common';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';


@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [FormsModule, BsDropdownModule],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {
  accountService = inject(AccountService)
  model: any = {};

  login() {
    this.accountService.login(this.model).subscribe({
      next: Response => {
        console.log(Response);

      },
      error: error => console.log(error)
    })
  }

  logout() {
    this.accountService.logout();
  }
}
