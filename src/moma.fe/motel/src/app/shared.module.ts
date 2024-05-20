import { NgModule } from "@angular/core";
import { FormatCurrencyMaskDirective } from "./directives/FormatCurrency";
import { CURRENCY_MASK_CONFIG } from "./directives/CurrencyMaskConfig";
import { NgxCurrencyDirective, NgxCurrencyInputMode } from "ngx-currency";

export const CustomCurrencyMaskConfig = {
    align: "left",
    allowNegative: true,
    decimal: ",",
    precision: 0,
    prefix: "",
    suffix: "",
    thousands: "."
};

@NgModule({
    declarations: [
    ],
    imports: [
    ],
    providers: [
    ],
    exports: [
    ]
})
export class SharedModule { }