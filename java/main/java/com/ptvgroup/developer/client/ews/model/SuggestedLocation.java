/*
 * EWS Road Distance
 * With the EWS Road Distance service you can query pre-calculated distances and additional information for relations between reference locations in Europe.
 *
 * The version of the OpenAPI document: 1.2
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
import com.ptvgroup.developer.client.ews.model.LocationType;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


/**
 * A location suggested for the input.
 */
@ApiModel(description = "A location suggested for the input.")
@JsonPropertyOrder({
  SuggestedLocation.JSON_PROPERTY_COUNTRY,
  SuggestedLocation.JSON_PROPERTY_POSTAL_CODE,
  SuggestedLocation.JSON_PROPERTY_LOCALITY,
  SuggestedLocation.JSON_PROPERTY_TYPE
})
@javax.annotation.processing.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-12-12T16:13:15.985307Z[Etc/UTC]")
public class SuggestedLocation {
  public static final String JSON_PROPERTY_COUNTRY = "country";
  private String country;

  public static final String JSON_PROPERTY_POSTAL_CODE = "postalCode";
  private String postalCode;

  public static final String JSON_PROPERTY_LOCALITY = "locality";
  private String locality;

  public static final String JSON_PROPERTY_TYPE = "type";
  private LocationType type = LocationType.CITY;

  public SuggestedLocation() { 
  }

  public SuggestedLocation country(String country) {
    this.country = country;
    return this;
  }

   /**
   * The country represented by its code according to [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2).
   * @return country
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(example = "DE", required = true, value = "The country represented by its code according to [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2).")
  @JsonProperty(JSON_PROPERTY_COUNTRY)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public String getCountry() {
    return country;
  }


  @JsonProperty(JSON_PROPERTY_COUNTRY)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setCountry(String country) {
    this.country = country;
  }


  public SuggestedLocation postalCode(String postalCode) {
    this.postalCode = postalCode;
    return this;
  }

   /**
   * The postal code, or zip-code, which is used by a postal authority of a country.
   * @return postalCode
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "76131", value = "The postal code, or zip-code, which is used by a postal authority of a country.")
  @JsonProperty(JSON_PROPERTY_POSTAL_CODE)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public String getPostalCode() {
    return postalCode;
  }


  @JsonProperty(JSON_PROPERTY_POSTAL_CODE)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setPostalCode(String postalCode) {
    this.postalCode = postalCode;
  }


  public SuggestedLocation locality(String locality) {
    this.locality = locality;
    return this;
  }

   /**
   * The name of the city or district in the language spoken in that country or region, always transliterated to Latin.
   * @return locality
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(example = "Karlsruhe", required = true, value = "The name of the city or district in the language spoken in that country or region, always transliterated to Latin.")
  @JsonProperty(JSON_PROPERTY_LOCALITY)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public String getLocality() {
    return locality;
  }


  @JsonProperty(JSON_PROPERTY_LOCALITY)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setLocality(String locality) {
    this.locality = locality;
  }


  public SuggestedLocation type(LocationType type) {
    this.type = type;
    return this;
  }

   /**
   * Get type
   * @return type
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")
  @JsonProperty(JSON_PROPERTY_TYPE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public LocationType getType() {
    return type;
  }


  @JsonProperty(JSON_PROPERTY_TYPE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setType(LocationType type) {
    this.type = type;
  }


  /**
   * Return true if this SuggestedLocation object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SuggestedLocation suggestedLocation = (SuggestedLocation) o;
    return Objects.equals(this.country, suggestedLocation.country) &&
        Objects.equals(this.postalCode, suggestedLocation.postalCode) &&
        Objects.equals(this.locality, suggestedLocation.locality) &&
        Objects.equals(this.type, suggestedLocation.type);
  }

  @Override
  public int hashCode() {
    return Objects.hash(country, postalCode, locality, type);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SuggestedLocation {\n");
    sb.append("    country: ").append(toIndentedString(country)).append("\n");
    sb.append("    postalCode: ").append(toIndentedString(postalCode)).append("\n");
    sb.append("    locality: ").append(toIndentedString(locality)).append("\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
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
