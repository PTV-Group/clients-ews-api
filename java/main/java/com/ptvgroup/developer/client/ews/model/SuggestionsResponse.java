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
import com.ptvgroup.developer.client.ews.model.SuggestedLocation;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.ArrayList;
import java.util.List;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


/**
 * SuggestionsResponse
 */
@JsonPropertyOrder({
  SuggestionsResponse.JSON_PROPERTY_SUGGESTIONS
})
@javax.annotation.processing.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2023-02-01T08:13:59.821599Z[Etc/UTC]")
public class SuggestionsResponse {
  public static final String JSON_PROPERTY_SUGGESTIONS = "suggestions";
  private List<SuggestedLocation> suggestions = null;

  public SuggestionsResponse() { 
  }

  public SuggestionsResponse suggestions(List<SuggestedLocation> suggestions) {
    this.suggestions = suggestions;
    return this;
  }

  public SuggestionsResponse addSuggestionsItem(SuggestedLocation suggestionsItem) {
    if (this.suggestions == null) {
      this.suggestions = new ArrayList<>();
    }
    this.suggestions.add(suggestionsItem);
    return this;
  }

   /**
   * The list of suggested locations sorted by **country**, **postalCode** and **locality**. Input localities matching a city name will be returned before those matching a subdistrict name.
   * @return suggestions
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "The list of suggested locations sorted by **country**, **postalCode** and **locality**. Input localities matching a city name will be returned before those matching a subdistrict name.")
  @JsonProperty(JSON_PROPERTY_SUGGESTIONS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public List<SuggestedLocation> getSuggestions() {
    return suggestions;
  }


  @JsonProperty(JSON_PROPERTY_SUGGESTIONS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setSuggestions(List<SuggestedLocation> suggestions) {
    this.suggestions = suggestions;
  }


  /**
   * Return true if this SuggestionsResponse object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SuggestionsResponse suggestionsResponse = (SuggestionsResponse) o;
    return Objects.equals(this.suggestions, suggestionsResponse.suggestions);
  }

  @Override
  public int hashCode() {
    return Objects.hash(suggestions);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SuggestionsResponse {\n");
    sb.append("    suggestions: ").append(toIndentedString(suggestions)).append("\n");
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

