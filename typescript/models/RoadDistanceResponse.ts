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
import type { ResponseLocation } from './ResponseLocation';
import {
    ResponseLocationFromJSON,
    ResponseLocationFromJSONTyped,
    ResponseLocationToJSON,
} from './ResponseLocation';

/**
 * 
 * @export
 * @interface RoadDistanceResponse
 */
export interface RoadDistanceResponse {
    /**
     * The distance of the relation [m].
     * @type {number}
     * @memberof RoadDistanceResponse
     */
    distance: number;
    /**
     * The distance of toll roads of the relation [m], if requested.
     * @type {number}
     * @memberof RoadDistanceResponse
     */
    tollDistance?: number;
    /**
     * 
     * @type {ResponseLocation}
     * @memberof RoadDistanceResponse
     */
    start: ResponseLocation;
    /**
     * 
     * @type {ResponseLocation}
     * @memberof RoadDistanceResponse
     */
    destination: ResponseLocation;
    /**
     * The version of the data by year.
     * @type {string}
     * @memberof RoadDistanceResponse
     */
    dataVersion: string;
    /**
     * The region which was searched for the reference locations.
     * @type {string}
     * @memberof RoadDistanceResponse
     */
    region: string;
}

/**
 * Check if a given object implements the RoadDistanceResponse interface.
 */
export function instanceOfRoadDistanceResponse(value: object): value is RoadDistanceResponse {
    if (!('distance' in value) || value['distance'] === undefined) return false;
    if (!('start' in value) || value['start'] === undefined) return false;
    if (!('destination' in value) || value['destination'] === undefined) return false;
    if (!('dataVersion' in value) || value['dataVersion'] === undefined) return false;
    if (!('region' in value) || value['region'] === undefined) return false;
    return true;
}

export function RoadDistanceResponseFromJSON(json: any): RoadDistanceResponse {
    return RoadDistanceResponseFromJSONTyped(json, false);
}

export function RoadDistanceResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): RoadDistanceResponse {
    if (json == null) {
        return json;
    }
    return {
        
        'distance': json['distance'],
        'tollDistance': json['tollDistance'] == null ? undefined : json['tollDistance'],
        'start': ResponseLocationFromJSON(json['start']),
        'destination': ResponseLocationFromJSON(json['destination']),
        'dataVersion': json['dataVersion'],
        'region': json['region'],
    };
}

export function RoadDistanceResponseToJSON(value?: RoadDistanceResponse | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'distance': value['distance'],
        'tollDistance': value['tollDistance'],
        'start': ResponseLocationToJSON(value['start']),
        'destination': ResponseLocationToJSON(value['destination']),
        'dataVersion': value['dataVersion'],
        'region': value['region'],
    };
}

