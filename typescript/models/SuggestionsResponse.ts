/* tslint:disable */
/* eslint-disable */
/**
 * EWS Road Distance
 * With the EWS Road Distance service you can query pre-calculated distances and additional information for relations between reference locations in Europe.
 *
 * The version of the OpenAPI document: 1.4
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
import type { SuggestedLocation } from './SuggestedLocation';
import {
    SuggestedLocationFromJSON,
    SuggestedLocationFromJSONTyped,
    SuggestedLocationToJSON,
} from './SuggestedLocation';

/**
 * 
 * @export
 * @interface SuggestionsResponse
 */
export interface SuggestionsResponse {
    /**
     * The list of suggested locations sorted by **country**, **postalCode** and **locality**.
     * Input localities matching a city name will be returned before those matching a subdistrict name.
     * @type {Array<SuggestedLocation>}
     * @memberof SuggestionsResponse
     */
    suggestions?: Array<SuggestedLocation>;
}

/**
 * Check if a given object implements the SuggestionsResponse interface.
 */
export function instanceOfSuggestionsResponse(value: object): boolean {
    let isInstance = true;

    return isInstance;
}

export function SuggestionsResponseFromJSON(json: any): SuggestionsResponse {
    return SuggestionsResponseFromJSONTyped(json, false);
}

export function SuggestionsResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): SuggestionsResponse {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'suggestions': !exists(json, 'suggestions') ? undefined : ((json['suggestions'] as Array<any>).map(SuggestedLocationFromJSON)),
    };
}

export function SuggestionsResponseToJSON(value?: SuggestionsResponse | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'suggestions': value.suggestions === undefined ? undefined : ((value.suggestions as Array<any>).map(SuggestedLocationToJSON)),
    };
}

