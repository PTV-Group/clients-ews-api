/* tslint:disable */
/* eslint-disable */
/**
 * EWS Road Distance
 * With the EWS Road Distance service you can query pre-calculated distances and additional information for relations between reference locations in Europe.
 *
 * The version of the OpenAPI document: 1.3
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


/**
 * The version of the data by year.
 * @export
 */
export const DataVersionType = {
    V2016: 'V2016',
    V2017: 'V2017',
    V2018: 'V2018',
    V2019: 'V2019',
    V2020: 'V2020',
    V2021: 'V2021',
    V2022: 'V2022',
    V2023: 'V2023',
    LATEST: 'LATEST'
} as const;
export type DataVersionType = typeof DataVersionType[keyof typeof DataVersionType];


export function DataVersionTypeFromJSON(json: any): DataVersionType {
    return DataVersionTypeFromJSONTyped(json, false);
}

export function DataVersionTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): DataVersionType {
    return json as DataVersionType;
}

export function DataVersionTypeToJSON(value?: DataVersionType | null): any {
    return value as any;
}

