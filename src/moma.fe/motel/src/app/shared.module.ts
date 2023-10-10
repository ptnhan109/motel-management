import { NgModule } from "@angular/core";
import { FormatCurrencyMaskDirective } from "./directives/FormatCurrency";
import { FormatCurrencyPipe } from "./pipes/format-currency.pipe";

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
        FormatCurrencyPipe
    ],
    imports: [
    ],
    providers: [
        FormatCurrencyPipe
    ],
    exports: [
        FormatCurrencyMaskDirective,
        FormatCurrencyPipe
    ]
})
export class SharedModule { }