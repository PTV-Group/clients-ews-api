/*
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


package com.ptvgroup.developer.client.ews.model;

import java.util.Objects;
import java.util.Arrays;
import java.util.Map;
import java.util.HashMap;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonTypeName;
import com.fasterxml.jackson.annotation.JsonValue;
import com.ptvgroup.developer.client.ews.model.ResponseLocation;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


/**
 * RoadDistanceResponse
 */
@JsonPropertyOrder({
  RoadDistanceResponse.JSON_PROPERTY_DISTANCE,
  RoadDistanceResponse.JSON_PROPERTY_TOLL_DISTANCE,
  RoadDistanceResponse.JSON_PROPERTY_START,
  RoadDistanceResponse.JSON_PROPERTY_DESTINATION,
  RoadDistanceResponse.JSON_PROPERTY_DATA_VERSION,
  RoadDistanceResponse.JSON_PROPERTY_REGION
})
@javax.annotation.processing.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2023-02-02T07:28:23.688857Z[Etc/UTC]")
public class RoadDistanceResponse {
  public static final String JSON_PROPERTY_DISTANCE = "distance";
  private Integer distance;

  public static final String JSON_PROPERTY_TOLL_DISTANCE = "tollDistance";
  private Integer tollDistance;

  public static final String JSON_PROPERTY_START = "start";
  private ResponseLocation start;

  public static final String JSON_PROPERTY_DESTINATION = "destination";
  private ResponseLocation destination;

  public static final String JSON_PROPERTY_DATA_VERSION = "dataVersion";
  private String dataVersion;

  public static final String JSON_PROPERTY_REGION = "region";
  private String region;

  public RoadDistanceResponse() { 
  }

  public RoadDistanceResponse distance(Integer distance) {
    this.distance = distance;
    return this;
  }

   /**
   * The distance of the relation [m].
   * minimum: 0
   * @return distance
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(example = "1422", required = true, value = "The distance of the relation [m].")
  @JsonProperty(JSON_PROPERTY_DISTANCE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public Integer getDistance() {
    return distance;
  }


  @JsonProperty(JSON_PROPERTY_DISTANCE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setDistance(Integer distance) {
    this.distance = distance;
  }


  public RoadDistanceResponse tollDistance(Integer tollDistance) {
    this.tollDistance = tollDistance;
    return this;
  }

   /**
   * The distance of toll roads of the relation [m], if requested.
   * minimum: 0
   * @return tollDistance
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "985", value = "The distance of toll roads of the relation [m], if requested.")
  @JsonProperty(JSON_PROPERTY_TOLL_DISTANCE)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public Integer getTollDistance() {
    return tollDistance;
  }


  @JsonProperty(JSON_PROPERTY_TOLL_DISTANCE)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setTollDistance(Integer tollDistance) {
    this.tollDistance = tollDistance;
  }


  public RoadDistanceResponse start(ResponseLocation start) {
    this.start = start;
    return this;
  }

   /**
   * Get start
   * @return start
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")
  @JsonProperty(JSON_PROPERTY_START)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public ResponseLocation getStart() {
    return start;
  }


  @JsonProperty(JSON_PROPERTY_START)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setStart(ResponseLocation start) {
    this.start = start;
  }


  public RoadDistanceResponse destination(ResponseLocation destination) {
    this.destination = destination;
    return this;
  }

   /**
   * Get destination
   * @return destination
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")
  @JsonProperty(JSON_PROPERTY_DESTINATION)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public ResponseLocation getDestination() {
    return destination;
  }


  @JsonProperty(JSON_PROPERTY_DESTINATION)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setDestination(ResponseLocation destination) {
    this.destination = destination;
  }


  public RoadDistanceResponse dataVersion(String dataVersion) {
    this.dataVersion = dataVersion;
    return this;
  }

   /**
   * The version of the data by year.
   * @return dataVersion
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "The version of the data by year.")
  @JsonProperty(JSON_PROPERTY_DATA_VERSION)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public String getDataVersion() {
    return dataVersion;
  }


  @JsonProperty(JSON_PROPERTY_DATA_VERSION)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setDataVersion(String dataVersion) {
    this.dataVersion = dataVersion;
  }


  public RoadDistanceResponse region(String region) {
    this.region = region;
    return this;
  }

   /**
   * The region which was searched for the reference locations.
   * @return region
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "The region which was searched for the reference locations.")
  @JsonProperty(JSON_PROPERTY_REGION)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public String getRegion() {
    return region;
  }


  @JsonProperty(JSON_PROPERTY_REGION)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setRegion(String region) {
    this.region = region;
  }


  /**
   * Return true if this RoadDistanceResponse object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RoadDistanceResponse roadDistanceResponse = (RoadDistanceResponse) o;
    return Objects.equals(this.distance, roadDistanceResponse.distance) &&
        Objects.equals(this.tollDistance, roadDistanceResponse.tollDistance) &&
        Objects.equals(this.start, roadDistanceResponse.start) &&
        Objects.equals(this.destination, roadDistanceResponse.destination) &&
        Objects.equals(this.dataVersion, roadDistanceResponse.dataVersion) &&
        Objects.equals(this.region, roadDistanceResponse.region);
  }

  @Override
  public int hashCode() {
    return Objects.hash(distance, tollDistance, start, destination, dataVersion, region);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RoadDistanceResponse {\n");
    sb.append("    distance: ").append(toIndentedString(distance)).append("\n");
    sb.append("    tollDistance: ").append(toIndentedString(tollDistance)).append("\n");
    sb.append("    start: ").append(toIndentedString(start)).append("\n");
    sb.append("    destination: ").append(toIndentedString(destination)).append("\n");
    sb.append("    dataVersion: ").append(toIndentedString(dataVersion)).append("\n");
    sb.append("    region: ").append(toIndentedString(region)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

