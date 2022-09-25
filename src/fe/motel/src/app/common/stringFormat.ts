export function FormatCurrency(input){
    return input.toFixed(2).replace(/\d(?=(\d{3})+\.)/g, '$&,');
}