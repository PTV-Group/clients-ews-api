/* tslint:disable */
/* eslint-disable */
/**
 * EWS Road Distance
 * With the EWS Road Distance service you can query pre-calculated distances and additional information for relations between reference locations in Europe.
 *
 * The version of the OpenAPI document: 1.5
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


/**
 * The region to search for the reference locations. See the concept on [EWS](./concepts/ews) for more information.
 * 
 * @export
 */
export const RegionType = {
    BEST_QUALITY: 'BEST_QUALITY',
    EUROPE: 'EUROPE',
    GERMANY: 'GERMANY'
} as const;
export type RegionType = typeof RegionType[keyof typeof RegionType];


export function instanceOfRegionType(value: any): boolean {
    for (const key in RegionType) {
        if (Object.prototype.hasOwnProperty.call(RegionType, key)) {
            if (RegionType[key as keyof typeof RegionType] === value) {
                return true;
            }
        }
    }
    return false;
}

export function RegionTypeFromJSON(json: any): RegionType {
    return RegionTypeFromJSONTyped(json, false);
}

export function RegionTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): RegionType {
    return json as RegionType;
}

export function RegionTypeToJSON(value?: RegionType | null): any {
    return value as any;
}

