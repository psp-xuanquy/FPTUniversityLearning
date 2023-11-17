package vn.fpt.elearning.dtos.question.request;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.EqualsAndHashCode;
import lombok.NoArgsConstructor;
import vn.fpt.elearning.core.BaseRequestData;
import vn.fpt.elearning.dtos.option.request.CreateOptionRequest;
import vn.fpt.elearning.enums.QuestionType;
import vn.fpt.elearning.model.FillCorrectInfo;

import javax.validation.constraints.NotBlank;
import javax.validation.constraints.NotNull;
import java.util.List;

@Data
@EqualsAndHashCode(callSuper = true)
@NoArgsConstructor
@AllArgsConstructor
public class UpdateQuestionRequest extends BaseRequestData {
    @NotBlank
    private String id;
    @NotNull
    private Integer questionNo;
    private String questionName;

    private List<FillCorrectInfo> fillCorrects;
    @NotNull
    private Float point;
    @NotNull
    private QuestionType questionType;

    private List<CreateOptionRequest> options;
}
