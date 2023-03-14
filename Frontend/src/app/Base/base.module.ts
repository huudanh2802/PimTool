import { InternalErrorComponent } from './components/internal-error/internal-error.component';
import { FormComponent } from './components/form/form.component';

import { CommonModule } from '@angular/common';
import { NgModule, ModuleWithProviders } from '@angular/core';
import { RouterModule } from '@angular/router';
import { TranslateModule } from '@ngx-translate/core';
import { ReactiveFormsModule } from '@angular/forms';

import { GridComponent } from './components';
import { NotFoundComponent } from './components/not-found/not-found.component';

// All exported items hear need to declare in public_api.ts
const DECLARED_EXPORTS = [
    GridComponent,FormComponent,NotFoundComponent,InternalErrorComponent
];

const ENTRY_COMPONENTS = [];

const RELAYED_EXPORTS = [
    CommonModule, TranslateModule,ReactiveFormsModule
];

@NgModule({
    declarations: [
        ...DECLARED_EXPORTS

    ],
    providers: [
    ],
    imports: [
        RouterModule,
        ...RELAYED_EXPORTS
    ],
    exports: [
        ...RELAYED_EXPORTS,
        ...DECLARED_EXPORTS
    ]
})
export class PIMBaseModule {
    static forRoot(): ModuleWithProviders<PIMBaseModule> {
        return {
            ngModule: PIMBaseModule
        };
    }
}
