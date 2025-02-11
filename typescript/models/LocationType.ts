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
 * The type of the location.
 * @export
 */
export const LocationType = {
    CITY: 'CITY',
    PORT: 'PORT',
    BORDER: 'BORDER'
} as const;
export type LocationType = typeof LocationType[keyof typeof LocationType];


export function instanceOfLocationType(value: any): boolean {
    for (const key in LocationType) {
        if (Object.prototype.hasOwnProperty.call(LocationType, key)) {
            if (LocationType[key as keyof typeof LocationType] === value) {
                return true;
            }
        }
    }
    return false;
}

export function LocationTypeFromJSON(json: any): LocationType {
    return LocationTypeFromJSONTyped(json, false);
}

export function LocationTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): LocationType {
    return json as LocationType;
}

export function LocationTypeToJSON(value?: LocationType | null): any {
    return value as any;
}

