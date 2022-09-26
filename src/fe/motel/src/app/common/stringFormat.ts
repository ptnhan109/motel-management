export function FormatCurrency(input){
    return input.toFixed(0).replace(/(.)(?=(\d{3})+$)/g,'$1,');
}