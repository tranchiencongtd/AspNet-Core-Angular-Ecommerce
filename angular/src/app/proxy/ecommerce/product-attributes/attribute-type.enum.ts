import { mapEnumToOptions } from '@abp/ng.core';

export enum AttributeType {
  Date = 0,
  Varchar = 1,
  Text = 2,
  Int = 3,
  Decimal = 4,
}

export const attributeTypeOptions = mapEnumToOptions(AttributeType);
