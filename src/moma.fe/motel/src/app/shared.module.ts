import { NgModule } from "@angular/core";
import { FormatCurrencyMaskDirective } from "./directives/FormatCurrency";

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
        FormatCurrencyMaskDirective,
    ],
    imports: [
    ],
    providers: [
        { provide: CURRENCY_MASK_CONFIG, useValue: CustomCurrencyMaskConfig }
    ],
    exports: [
        FormatCurrencyMaskDirective,
    ]
})
export class SharedModule { }