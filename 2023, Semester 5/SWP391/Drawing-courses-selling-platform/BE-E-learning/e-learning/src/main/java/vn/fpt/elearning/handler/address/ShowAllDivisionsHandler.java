package vn.fpt.elearning.handler.address;

import lombok.RequiredArgsConstructor;
import lombok.extern.slf4j.Slf4j;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpMethod;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Component;
import vn.fpt.elearning.client.IRestClient;
import vn.fpt.elearning.core.RequestHandler;
import vn.fpt.elearning.dtos.address.request.ShowAllRequest;
import vn.fpt.elearning.dtos.address.response.ShowAllResponse;
import vn.fpt.elearning.model.ProvinceDto;

import java.util.List;

@Component
@RequiredArgsConstructor
@Slf4j
public class ShowAllDivisionsHandler extends RequestHandler<ShowAllRequest, ShowAllResponse> {

    private final IRestClient restClient;
    @Value("${address-client.get-all-url}")
    private String host;
    @Override
    public ShowAllResponse handle(ShowAllRequest request) {
        String url = host;
        ResponseEntity<Object> response = restClient.callAPI(url, HttpMethod.GET, new HttpHeaders(), null);
        List<ProvinceDto> divisionDtos = (List<ProvinceDto>) response.getBody();
        return new ShowAllResponse(divisionDtos);
    }
}
