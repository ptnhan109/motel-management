export function FormatCurrency(input) {
    return input.toFixed(0).replace(/(.)(?=(\d{3})+$)/g, '$1,');
}

export function RemoveNullable(obj) {
    return Object.entries(obj)
      .filter(([_, v]) => v != null)
      .reduce((acc, [k, v]) => ({ ...acc, [k]: v }), {});
  }