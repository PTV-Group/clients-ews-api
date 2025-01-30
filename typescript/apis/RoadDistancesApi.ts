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


import * as runtime from '../runtime';
import type {
  DataVersionType,
  ErrorResponse,
  LocationType,
  RegionType,
  RequestLocation,
  ResultsType,
  RoadDistanceResponse,
  SuggestionsResponse,
} from '../models/index';
import {
    DataVersionTypeFromJSON,
    DataVersionTypeToJSON,
    ErrorResponseFromJSON,
    ErrorResponseToJSON,
    LocationTypeFromJSON,
    LocationTypeToJSON,
    RegionTypeFromJSON,
    RegionTypeToJSON,
    RequestLocationFromJSON,
    RequestLocationToJSON,
    ResultsTypeFromJSON,
    ResultsTypeToJSON,
    RoadDistanceResponseFromJSON,
    RoadDistanceResponseToJSON,
    SuggestionsResponseFromJSON,
    SuggestionsResponseToJSON,
} from '../models/index';

export interface GetRelationRequest {
    start?: RequestLocation;
    destination?: RequestLocation;
    region?: RegionType;
    dataVersion?: DataVersionType;
    results?: Array<ResultsType>;
}

export interface GetSuggestionsRequest {
    country?: string;
    postalCode?: string;
    locality?: string;
    region?: RegionType;
    dataVersion?: DataVersionType;
    type?: LocationType;
    limit?: number;
}

/**
 * 
 */
export class RoadDistancesApi extends runtime.BaseAPI {

    /**
     * Gets the truck distance and additional information for a relation between two locations.
     */
    async getRelationRaw(requestParameters: GetRelationRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<RoadDistanceResponse>> {
        const queryParameters: any = {};

        if (requestParameters['start'] != null) {
            queryParameters['start'] = requestParameters['start'];
        }

        if (requestParameters['destination'] != null) {
            queryParameters['destination'] = requestParameters['destination'];
        }

        if (requestParameters['region'] != null) {
            queryParameters['region'] = requestParameters['region'];
        }

        if (requestParameters['dataVersion'] != null) {
            queryParameters['dataVersion'] = requestParameters['dataVersion'];
        }

        if (requestParameters['results'] != null) {
            queryParameters['results'] = requestParameters['results']!.join(runtime.COLLECTION_FORMATS["csv"]);
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["apiKey"] = await this.configuration.apiKey("apiKey"); // apiKeyAuth authentication
        }

        const response = await this.request({
            path: `/relations`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => RoadDistanceResponseFromJSON(jsonValue));
    }

    /**
     * Gets the truck distance and additional information for a relation between two locations.
     */
    async getRelation(requestParameters: GetRelationRequest = {}, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<RoadDistanceResponse> {
        const response = await this.getRelationRaw(requestParameters, initOverrides);
        return await response.value();
    }

    /**
     * Gets suggestions for a location. Provide at least two characters in **postalCode** or **locality** to obtain results.
     */
    async getSuggestionsRaw(requestParameters: GetSuggestionsRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<SuggestionsResponse>> {
        const queryParameters: any = {};

        if (requestParameters['country'] != null) {
            queryParameters['country'] = requestParameters['country'];
        }

        if (requestParameters['postalCode'] != null) {
            queryParameters['postalCode'] = requestParameters['postalCode'];
        }

        if (requestParameters['locality'] != null) {
            queryParameters['locality'] = requestParameters['locality'];
        }

        if (requestParameters['region'] != null) {
            queryParameters['region'] = requestParameters['region'];
        }

        if (requestParameters['dataVersion'] != null) {
            queryParameters['dataVersion'] = requestParameters['dataVersion'];
        }

        if (requestParameters['type'] != null) {
            queryParameters['type'] = requestParameters['type'];
        }

        if (requestParameters['limit'] != null) {
            queryParameters['limit'] = requestParameters['limit'];
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["apiKey"] = await this.configuration.apiKey("apiKey"); // apiKeyAuth authentication
        }

        const response = await this.request({
            path: `/suggestions`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => SuggestionsResponseFromJSON(jsonValue));
    }

    /**
     * Gets suggestions for a location. Provide at least two characters in **postalCode** or **locality** to obtain results.
     */
    async getSuggestions(requestParameters: GetSuggestionsRequest = {}, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<SuggestionsResponse> {
        const response = await this.getSuggestionsRaw(requestParameters, initOverrides);
        return await response.value();
    }

}
