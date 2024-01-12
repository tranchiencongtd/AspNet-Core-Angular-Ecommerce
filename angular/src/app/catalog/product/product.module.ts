import { NgModule } from '@angular/core';
import { ProductComponent } from './product.component';
import { PanelModule } from 'primeng/panel';
import { TableModule } from 'primeng/table';
import { PaginatorModule } from 'primeng/paginator';
import { BlockUIModule } from 'primeng/blockui';
import { ButtonModule } from 'primeng/button';
import { ProgressSpinnerModule } from 'primeng/progressspinner';
import { SharedModule } from 'src/app/shared/shared.module';
import { ProductRoutingModule } from './product-routing.module';
import { DropdownModule } from 'primeng/dropdown';
import { InputTextModule } from 'primeng/inputtext';

@NgModule({
    imports: [
        BlockUIModule,
        ButtonModule,
        PanelModule,
        TableModule,
        PaginatorModule,
        ProgressSpinnerModule,
        SharedModule,
        ProductRoutingModule,
        DropdownModule,
        InputTextModule
    ],
    declarations: [ProductComponent],
})
export class ProductModule { }
