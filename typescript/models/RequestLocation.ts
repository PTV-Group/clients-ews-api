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

import { mapValues } from '../runtime';
import type { LocationType } from './LocationType';
import {
    LocationTypeFromJSON,
    LocationTypeFromJSONTyped,
    LocationTypeToJSON,
} from './LocationType';

/**
 * 
 * @export
 * @interface RequestLocation
 */
export interface RequestLocation {
    /**
     * The country represented by its code according to [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2).
     * @type {string}
     * @memberof RequestLocation
     */
    country?: string;
    /**
     * The postal code, or zip-code, which is used by a postal authority of a country.
     * @type {string}
     * @memberof RequestLocation
     */
    postalCode?: string;
    /**
     * The name of a locality in the language spoken in that country or region, always transliterated to Latin.
     * It can be the name of a city (e.g. 'Karlsruhe'), a subdistrict (e.g. 'Durlach') or a combination of both
     * separated with a blank (e.g. 'Karlsruhe Durlach').
     * @type {string}
     * @memberof RequestLocation
     */
    locality?: string;
    /**
     * 
     * @type {LocationType}
     * @memberof RequestLocation
     */
    type?: LocationType;
}



/**
 * Check if a given object implements the RequestLocation interface.
 */
export function instanceOfRequestLocation(value: object): value is RequestLocation {
    return true;
}

export function RequestLocationFromJSON(json: any): RequestLocation {
    return RequestLocationFromJSONTyped(json, false);
}

export function RequestLocationFromJSONTyped(json: any, ignoreDiscriminator: boolean): RequestLocation {
    if (json == null) {
        return json;
    }
    return {
        
        'country': json['country'] == null ? undefined : json['country'],
        'postalCode': json['postalCode'] == null ? undefined : json['postalCode'],
        'locality': json['locality'] == null ? undefined : json['locality'],
        'type': json['type'] == null ? undefined : LocationTypeFromJSON(json['type']),
    };
}

export function RequestLocationToJSON(value?: RequestLocation | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'country': value['country'],
        'postalCode': value['postalCode'],
        'locality': value['locality'],
        'type': LocationTypeToJSON(value['type']),
    };
}

